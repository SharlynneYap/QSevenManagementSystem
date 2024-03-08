    using System;
    using System.Data;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;

    namespace QSevenManagementSystem
    {
        public static class ConnectToSQL
        {
            public static string database;
            public static string connectionString;
            public static MySqlConnection cnn;
            public static void initialize()
            {
                connectionString = "server=localhost;uid=root;pwd=\"\";";
                database = "db_qsevenc";
                cnn = new MySqlConnection(connectionString);

                try
                {
                    cnn.Open();

                    // Check if the database exists
                    MySqlCommand checkDbCmd = cnn.CreateCommand();
                    checkDbCmd.CommandText = "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '"+database+"';";
                    object result = checkDbCmd.ExecuteScalar();

                    if (result == null)
                    {
                        // Database does not exist, create it
                        MySqlCommand createDbCmd = cnn.CreateCommand();
                        createDbCmd.CommandText = "CREATE DATABASE IF NOT EXISTS "+database+"; use "+database+";";
                        createDbCmd.ExecuteNonQuery();
                        MessageBox.Show("Database created successfully!");

                        // Create initial tables
                        createTables(cnn);
                        createViews(cnn);
                        createInitialRecords(cnn);

                    }
                    else
                    {
                        MessageBox.Show("Database already exists!");
                        executeQuery(cnn, "use "+database+"; ");
                    }

                    MessageBox.Show("Connection Open!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection! " + ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
            
            private static void createTables(MySqlConnection connection)// Creates initial tables
            {
                try
                {
                // Create table queries
                string createTableQuery = @"CREATE TABLE tbl_renter ( 
	                renter_id INT(5) PRIMARY KEY AUTO_INCREMENT, 
 	                renter_fname VARCHAR(20) NOT NULL, 
 	                renter_mname VARCHAR(20), 
 	                renter_lname VARCHAR(20) NOT NULL, 
 	                renter_contact VARCHAR(12) NOT NULL, 
 	                renter_dob DATE NOT NULL, 
 	                renter_address VARCHAR(200) NOT NULL, 
 	                renter_sex CHAR(1) NOT NULL, 
 	                CONSTRAINT check_renter_sex CHECK (renter_sex IN ('M', 'F')) 
                ); 
                CREATE TABLE tbl_movein ( 
 	                movein_id INT(5) AUTO_INCREMENT PRIMARY KEY, 
 	                movein_total_deposit_paid DECIMAL(7,2) NOT NULL, 
 	                movein_date DATE NOT NULL 
                ); 
                CREATE TABLE tbl_room ( 
	                room_id VARCHAR(2) PRIMARY KEY, 
 	                room_floor INT(3) NOT NULL, 
 	                room_max_renters INT(2) NOT NULL 
                ); 
                CREATE TABLE tbl_registration ( 
 	                registration_id INT(5) AUTO_INCREMENT, 
 	                renter_id INT(5) NOT NULL, 
 	                room_id VARCHAR(2) NOT NULL, 
 	                movein_id INT(5) NOT NULL, 
 	                registration_date DATE NOT NULL, 
	                PRIMARY KEY (registration_id, renter_id), 
	                FOREIGN KEY (renter_id) REFERENCES tbl_renter(renter_id), 
 	                FOREIGN KEY (room_id) REFERENCES tbl_room(room_id), 
 	                FOREIGN KEY (movein_id) REFERENCES tbl_movein(movein_id) 
                ); 
                CREATE TABLE tbl_moveout( 
	                moveout_id INT(5) PRIMARY KEY AUTO_INCREMENT, 
	                registration_id INT(5) NOT NULL, 
	                moveout_date DATE NOT NULL, 
	                FOREIGN KEY (registration_id) REFERENCES tbl_registration(registration_id) 
                ); 
                CREATE TABLE tbl_room_damage_type ( 
	                rdt_id INT(2) PRIMARY KEY AUTO_INCREMENT, 
	                rdt_description varchar(30) NOT NULL
                ); 
                CREATE TABLE tbl_room_damage_record( 
	                rd_id INT(5) AUTO_INCREMENT, 
	                room_id VARCHAR(2) NOT NULL, 
	                rdt_id INT(2) NOT NULL, 
	                rd_description VARCHAR(100), 
	                rd_total_damages DECIMAL(7,2) NOT NULL, 
	                rd_date DATE NOT NULL, 
	                PRIMARY KEY(rd_id, room_id), 
	                FOREIGN KEY (room_id) REFERENCES tbl_room(room_id), 
	                FOREIGN KEY (rdt_id) REFERENCES tbl_room_damage_type(rdt_id) 
                ); 
                CREATE TABLE tbl_room_availability_type ( 
	                rat_id INT(2) PRIMARY KEY AUTO_INCREMENT, 
	                rat_description VARCHAR(30) NOT NULL
                ); 
                Create table tbl_room_availability_record( 
	                ra_id INT (5) AUTO_INCREMENT, 
	                room_id VARCHAR(2) NOT NULL, 
	                rat_id INT(2) NOT NULL, 
	                ra_date DATE NOT NULL, 
	                PRIMARY KEY(ra_id,room_id), 
	                FOREIGN KEY(room_id) REFERENCES tbl_room(room_id), 
	                FOREIGN KEY(rat_id) REFERENCES tbl_room_availability_type(rat_id) 
                ); 
                CREATE TABLE tbl_room_price_record( 
 	                rp_id INT(5) AUTO_INCREMENT, 
 	                room_id VARCHAR(2), 
 	                rp_price DECIMAL(7,2) NOT NULL, 
 	                rp_date DATE NOT NULL, 
 	                PRIMARY KEY(rp_id,room_id), 
 	                FOREIGN KEY (room_ID) REFERENCES tbl_room(room_id) 
                ); 
                CREATE TABLE tbl_dpn ( 
 	                dpn_id INT(5) AUTO_INCREMENT PRIMARY KEY, 
 	                registration_id INT(5) NOT NULL, 
 	                dpn_date_month INT(2) NOT NULL, 
 	                dpn_date_issued DATE NOT NULL, 
 	                dpn_is_deposit_used TINYINT(1) NOT NULL, 
 	                FOREIGN KEY (registration_id) REFERENCES tbl_registration(registration_id) 
                ); 
                CREATE TABLE tbl_receipt ( 
 	                receipt_id INT(5) AUTO_INCREMENT, 
 	                dpn_id INT(5), 
 	                receipt_amount_paid DECIMAL(7,2) NOT NULL, 
 	                receipt_date_issued DATE NOT NULL, 
 	                PRIMARY KEY (receipt_id, dpn_id), 
 	                FOREIGN KEY (dpn_id) REFERENCES tbl_dpn(dpn_id) 
                ); 
                CREATE TABLE tbl_bill_type ( 
 	                bt_id INT(2) AUTO_INCREMENT PRIMARY KEY, 
 	                bt_description VARCHAR(30) NOT NULL 
                ); 
                CREATE TABLE tbl_bill_rate_record ( 
 	                br_id INT(5) AUTO_INCREMENT, 
 	                bt_id INT(2), 
 	                br_price DECIMAL(4,2) NOT NULL, 
 	                br_date DATE NOT NULL, 
 	                PRIMARY KEY(br_id,bt_id), 
 	                FOREIGN KEY (bt_id) REFERENCES tbl_bill_type(bt_id) 
                ); 
                CREATE TABLE tbl_bill ( 
 	                bill_id INT(5) AUTO_INCREMENT, 
 	                dpn_id INT(5), 
 	                bt_id INT(2) NOT NULL, 
 	                bill_meter_start_month DECIMAL(10,2) NOT NULL, 
 	                bill_meter_end_month DECIMAL(10,2) NOT NULL, 
 	                PRIMARY KEY (bill_id, dpn_id), 
 	                FOREIGN KEY (dpn_id) REFERENCES tbl_dpn(dpn_id), 
 	                FOREIGN KEY (bt_id) REFERENCES tbl_bill_type(bt_id) 
                ); 
                CREATE TABLE tbl_other_charges ( 
 	                oc_id INT(5) AUTO_INCREMENT, 
 	                dpn_id INT(5), 
 	                oc_description VARCHAR(100), 
 	                oc_total DECIMAL(7,2) NOT NULL, 
 	                PRIMARY KEY (oc_id, dpn_id), 
 	                FOREIGN KEY (dpn_id) REFERENCES tbl_dpn(dpn_id) 
                ); 
                ";

                    // Execute queries
                    executeQuery(connection, createTableQuery);

                    MessageBox.Show("Tables created successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating tables: " + ex.Message);
                }
            }

            private static void createViews(MySqlConnection connection) //Creates initial views
            {
                try
                {
                // Create table queries
                string createViewsQuery = @"CREATE VIEW vw_room_availability_history AS 
                    SELECT 
                     r.room_id, 
                     rpr.rp_price AS room_price, 
                     r.room_max_renters, 
                     r.room_floor, 
                     rat.rat_description AS rat_description, 
                     rar.ra_date 
                    FROM 
                     tbl_room r 
                    JOIN 
                     tbl_room_price_record rpr ON r.room_id = rpr.room_id 
                    JOIN 
                     tbl_room_availability_record rar ON r.room_id = rar.room_id 
                    JOIN 
                     tbl_room_availability_type rat ON rar.rat_id = rat.rat_id;


                    CREATE VIEW vw_room_damage_record AS
                    SELECT
                        rd.rd_id,
                        rd.room_id,
                        rdt.rdt_description,
                        rd.rd_description,
                        rd.rd_total_damages,
                        rd.rd_date
                    FROM
                        tbl_room_damage_record rd
                    JOIN
                        tbl_room_damage_type rdt ON rd.rdt_id = rdt.rdt_id;
                    

                    CREATE VIEW vw_room_price_history AS
                    SELECT 
                        r.Room_ID,
                        r.Room_floor,
                        r.Room_max_renters,
                        p.RP_price,
                        p.RP_date
                    FROM 
                        tbl_room r
                    JOIN 
                        tbl_room_price_record p ON r.Room_ID = p.Room_ID;


                    CREATE VIEW vw_bill_total AS   
                    SELECT     

                        b.bill_id,     

                        b.dpn_id,     

                        b.bt_id,    

                        b.bill_meter_start_month AS bill_meterstartmonth,     

                        b.bill_meter_end_month AS bill_meterendmonth,     

                        (SELECT br_price   

                         FROM tbl_bill_rate_record   

                         WHERE bt_id = b.bt_id   

                         AND br_date <= (SELECT dpn_date_issued FROM tbl_dpn WHERE dpn_id = b.dpn_id)   

                         ORDER BY br_date DESC   

                         LIMIT 1) AS bill_rate,     

                        ROUND((b.bill_meter_end_month - b.bill_meter_start_month) *   

                              (SELECT br_price   

                               FROM tbl_bill_rate_record   

                               WHERE bt_id = b.bt_id   

                               AND br_date <= (SELECT dpn_date_issued FROM tbl_dpn WHERE dpn_id = b.dpn_id)   

                               ORDER BY br_date DESC   

                               LIMIT 1), 2) AS bill_total     

                    FROM     

                        tbl_bill b;  


                CREATE VIEW vw_dpn_total AS 
                SELECT 
                    d.dpn_id, 
                    d.registration_id, 
                    d.dpn_date_month, 
                    d.dpn_date_issued, 
                    d.dpn_is_deposit_used, 
                    IF(d.dpn_is_deposit_used, 
                        -(COALESCE(m.movein_total_deposit_paid, 0) - ( 
                            COALESCE((SELECT rp_price 
                                      FROM tbl_room_price_record 
                                      WHERE room_id = r.room_id 
                                        AND rp_date <= d.dpn_date_issued 
                                      ORDER BY rp_date DESC 
                                      LIMIT 1), 0) 
                            + COALESCE((SELECT SUM(b.bill_total) 
                                        FROM vw_bill_total b 
                                        WHERE b.dpn_id = d.dpn_id), 0) 
                            + COALESCE((SELECT SUM(oc_total) 
                                        FROM tbl_other_charges 
                                        WHERE dpn_id = d.dpn_id), 0) 
                        )), 
                        (COALESCE((SELECT rp_price 
                                   FROM tbl_room_price_record 
                                   WHERE room_id = r.room_id 
                                     AND rp_date <= d.dpn_date_issued 
                                   ORDER BY rp_date DESC 
                                   LIMIT 1), 0) 
                         + COALESCE((SELECT SUM(b.bill_total) 
                                     FROM vw_bill_total b 
                                     WHERE b.dpn_id = d.dpn_id), 0) 
                         + COALESCE((SELECT SUM(oc_total) 
                                     FROM tbl_other_charges 
                                     WHERE dpn_id = d.dpn_id), 0)) 
                    ) AS DPN_total 
                FROM 
                    tbl_dpn d 
                INNER JOIN tbl_registration reg ON d.registration_id = reg.registration_id 
                INNER JOIN tbl_movein m ON reg.movein_id = m.movein_id 
                INNER JOIN tbl_room r ON reg.room_id = r.room_id; 

                
                CREATE VIEW vw_receipt_is_fully_paid AS  
                SELECT    
                    r.receipt_id,  
                    r.dpn_id,  
                    r.receipt_amount_paid,  
                    r.receipt_date_issued, 
                    CASE    
                        WHEN r.receipt_amount_paid >= (d.dpn_total) THEN 1   
                        ELSE 0   
                    END AS receipt_is_fully_paid  
                FROM   
                    tbl_receipt r  
                JOIN  
                   vw_dpn_total d ON r.dpn_id = d.dpn_id; 


                CREATE VIEW vw_bill_rate_history AS
                SELECT 
                    BRR.BT_ID,
                    BT.BT_description,
                    BRR.BR_price,
                    BRR.BR_date
                FROM 
                    tbl_Bill_Rate_Record BRR
                JOIN 
                    tbl_Bill_Type BT ON BT.BT_ID = BRR.BT_ID;
                
                
                CREATE VIEW vw_renter_history AS
                SELECT 
                    R.Registration_ID,
                    RN.Renter_ID,
                    RN.Renter_FName,
                    RN.Renter_MName,
                    RN.Renter_LName,
                    RN.Renter_contact,
                    RN.Renter_DOB,
                    RN.Renter_sex,
                    RN.Renter_address,
                    RM.Room_ID,
                    MI.MoveIn_total_Deposit_Paid,
                    MI.MoveIn_date,
                    R.Registration_date
                FROM 
                    tbl_Registration R
                JOIN 
                    tbl_Renter RN ON R.Renter_ID = RN.Renter_ID
                JOIN 
                    tbl_MoveIn MI ON R.MoveIn_ID = MI.MoveIn_ID
                JOIN 
                    tbl_Room RM ON R.Room_ID = RM.Room_ID;
                ";

                    // Execute queries
                    executeQuery(connection, createViewsQuery);

                    MessageBox.Show("Views created successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating views: " + ex.Message);
                }
            }

        private static void createInitialRecords(MySqlConnection connection) //Creates initial views
        {
            try
            {
                // Create record queries
                string createRecordsQuery = @"insert into tbl_room_availability_type values(1,'Unoccupied');
                    insert into tbl_room_availability_type values(2,'Reserved');
                    insert into tbl_room_availability_type values(3,'Occupied');
                    insert into tbl_room_availability_type values(4,'Removed');

                    insert into tbl_room_damage_type values(1,'Maintenance');
                    insert into tbl_room_damage_type values(2,'Damage done by renter');

                    insert into tbl_bill_type values(1,'Electricity');
                    insert into tbl_bill_type values(2,'Water');
                    ";

                // Execute queries
                executeQuery(connection, createRecordsQuery);

                MessageBox.Show("Records created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating records: " + ex.Message);
            }
        }

        private static void executeQuery(MySqlConnection connection, string query)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }

            public static void insertRecord(string table, string column, string values)
            {
                try
                {
                    if (cnn.State == ConnectionState.Closed)
                    {
                        cnn.Open();
                    }

                    string insertQuery = $"INSERT INTO {table} ({column}) VALUES ({values});";

                    executeQuery(cnn, insertQuery);

                    cnn.Close();

                    MessageBox.Show("Record inserted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting record: " + ex.Message);
                }
            }

        public static string readTableString(string query)
            {
                string value = null;

                try
                {
                    if (cnn.State == ConnectionState.Closed)
                    {
                        cnn.Open();
                    }
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        value = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading value: " + ex.Message);
                }
                finally
                {
                    cnn.Close();
                }

                return value;
            }

        public static string[,] readTableArray(string query)
        {
            string[,] values = null;

            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Get the number of columns
                int colCount = reader.FieldCount;

                // Get the number of rows
                int rowCount = 0;
                while (reader.Read())
                {
                    rowCount++;
                }

                // Reset the reader
                reader.Close();
                reader = cmd.ExecuteReader();

                // Initialize the values array
                values = new string[rowCount, colCount];

                // Populate the values array
                int row = 0;
                while (reader.Read())
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        values[row, col] = reader[col].ToString();
                    }
                    row++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading table: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }

            return values;
        }


        public static void LoadDataGridView(DataGridView dataGridView, string query)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Create a MySqlDataAdapter to execute the query and fill a DataTable
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the retrieved data
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data into DataGridView: " + ex.Message);
                }

            }

        }
    }
