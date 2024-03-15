using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QSevenManagementSystem
{
    public static class ConnectToSQL
    {
        private static string database;
        private static string connectionString;
        private static MySqlConnection cnn;

        static ConnectToSQL(){
            initialize();
        }
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
                checkDbCmd.CommandText = "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '" + database + "';";
                object result = checkDbCmd.ExecuteScalar();

                if (result == null)
                {
                    createDatabase();
                }
                else
                {
                    MessageBox.Show("Database already exists!");
                    executeQuery(cnn, "use " + database + "; ");
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
        private static void createDatabase()
        {
            MySqlCommand createDbCmd = cnn.CreateCommand();
            createDbCmd.CommandText = "CREATE DATABASE IF NOT EXISTS " + database + "; use " + database + ";";
            createDbCmd.ExecuteNonQuery();
            MessageBox.Show("Database created successfully!");

            //creating tables, views, and records
            createTables(cnn);
            createViews(cnn);
            createInitialRecords(cnn);
        }
        private static void createTables(MySqlConnection connection)// Creates initial tables
        {
            try
            {
                // Create table queries
                string createTableQuery = @"
                CREATE TABLE tbl_renter ( 
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

                CREATE TABLE tbl_moveIn (
                    MoveIn_ID INT(5) AUTO_INCREMENT PRIMARY KEY,
                    Renter_ID INT(5) NOT NULL,
                    MoveIn_date DATE NOT NULL,
                    FOREIGN KEY (Renter_ID) REFERENCES tbl_renter(Renter_ID)
                );

                CREATE TABLE tbl_moveOut (
                    MoveOut_ID INT(5) AUTO_INCREMENT PRIMARY KEY,
                    Renter_ID INT(5) NOT NULL,
                    MoveOut_date DATE NOT NULL,
                    FOREIGN KEY (Renter_ID) REFERENCES tbl_renter(Renter_ID)
                );
               
                CREATE TABLE tbl_room ( 
	                room_id VARCHAR(2) PRIMARY KEY, 
 	                room_floor INT(3) NOT NULL, 
 	                room_max_renters INT(2) NOT NULL 
                ); 

                CREATE TABLE tbl_Deposit (
                    Deposit_ID INT(5) AUTO_INCREMENT PRIMARY KEY,
                    Deposit_total DECIMAL(7,2) NOT NULL
                );


                CREATE TABLE tbl_registration (
                    Registration_ID INT(5) AUTO_INCREMENT,
                    Renter_ID INT(5) NOT NULL,
                    Room_ID VARCHAR(2) NOT NULL,
                    Deposit_ID INT(5) NOT NULL,
                    Registration_date DATE NOT NULL,
                    PRIMARY KEY (Registration_ID, Renter_ID),
                    FOREIGN KEY (Renter_ID) REFERENCES tbl_renter(Renter_ID),
                    FOREIGN KEY (Room_ID) REFERENCES tbl_Room(Room_ID),
                    FOREIGN KEY (Deposit_ID) REFERENCES tbl_Deposit(Deposit_ID)
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
                string createViewsQuery = @"

                CREATE VIEW vw_current_rooms_availability AS
                SELECT 
                    room_id AS 'Room ID',
                    CASE
                        WHEN MAX(rat_id) = 4 THEN 'Removed'
                        WHEN MAX(rat_id) = 3 THEN 'Occupied'
                        WHEN MAX(rat_id) = 2 THEN 'Reserved'
                        ELSE 'Unoccupied'
                    END AS 'Current Availability'
                FROM 
                    tbl_room_availability_record
                WHERE 
                    ra_date <= CURRENT_DATE
                GROUP BY 
                    room_id;


                CREATE VIEW vw_dpn_renter_details AS
                SELECT 
                    r.room_id AS 'Room ID',
                    rp.rp_price AS 'Room Price',
                    r.room_floor AS 'Room Floor',
                    r.room_max_renters AS 'Max # of Renters',
                    reg.registration_id AS 'Registration ID'
                FROM 
                    tbl_registration reg
                JOIN 
                    tbl_renter rt ON reg.renter_id = rt.renter_id
                JOIN 
                    tbl_room r ON reg.room_id = r.room_id
                LEFT JOIN 
                    tbl_moveout mo ON reg.renter_id = mo.renter_id
                JOIN 
                    (SELECT room_id, rp_price, rp_date,
                            ROW_NUMBER() OVER (PARTITION BY room_id ORDER BY rp_date DESC) AS rn
                     FROM tbl_room_price_record
                     WHERE rp_date <= CURDATE()
                     ) rp ON r.room_id = rp.room_id AND rp.rn = 1
                JOIN 
                    tbl_room_availability_record RAR ON r.room_id = RAR.room_id
                JOIN 
                    tbl_room_availability_type RAT ON RAR.rat_id = RAT.rat_id
                WHERE 
                    (mo.moveout_date IS NULL OR mo.moveout_date > CURDATE())
                    AND RAT.rat_description = 'occupied'
                    AND NOT EXISTS (
                        SELECT 1
                        FROM tbl_room_availability_record RAR_HIST
                        JOIN tbl_room_availability_type RAT_HIST ON RAR_HIST.rat_id = RAT_HIST.rat_id
                        WHERE RAR_HIST.room_id = r.room_id AND RAT_HIST.rat_id = 4
                    )
                GROUP BY reg.registration_id;

                CREATE VIEW vw_moveout_history AS
                SELECT 
                R.registration_id AS 'Registration ID',
                R.renter_id AS 'Renter ID',
                RT.renter_fname AS 'First Name',
                RT.renter_mname AS 'Middle Name',
                RT.renter_lname AS 'Last Name',
                RT.renter_contact AS 'Contact',
                RT.renter_dob AS 'Date of Birth',
                RT.renter_sex AS 'Sex',
                RT.renter_address AS 'Address',
                R.room_id AS 'Room ID',
                MO.MoveOut_ID AS 'Move Out ID',
                MO.MoveOut_date AS 'Move Out Date',
                R.registration_date
            FROM 
                tbl_registration R
            JOIN 
                tbl_renter RT ON R.renter_id = RT.renter_id
            LEFT JOIN 
                tbl_moveout MO ON RT.renter_id = MO.Renter_ID
            WHERE 
                MO.MoveOut_date IS NOT NULL AND MO.MoveOut_date <= CURRENT_DATE;


                CREATE VIEW vw_movein_history AS
                SELECT 
                    REG.registration_id AS 'Registration ID',
                    R.renter_id AS 'Renter ID',
                    R.renter_fname AS 'First Name',
                    R.renter_mname AS 'Middle Name',
                    R.renter_lname AS 'Last Name',
                    R.renter_contact AS 'Contact #',
                    R.renter_dob AS 'DOB',
                    R.renter_sex AS 'Sex',
                    R.renter_address AS 'Address',
                    RO.room_id AS 'Room ID',
                    D.deposit_total AS 'Total Deposit',
                    MI.movein_ID AS 'Move In ID',
                    MI.movein_date AS 'Move In Date',
                    REG.registration_date AS 'Registration Date'
                FROM 
                    tbl_renter R
                JOIN 
                    tbl_registration REG ON R.renter_id = REG.renter_id
                JOIN 
                    tbl_room RO ON REG.room_id = RO.room_id
                JOIN 
                    tbl_movein MI ON REG.renter_id = MI.renter_id
                JOIN 
                    tbl_deposit D ON REG.deposit_id = D.deposit_id
                LEFT JOIN 
                    tbl_moveout MO ON REG.renter_id = MO.renter_id
                WHERE 
                    MI.movein_date <= CURDATE();


               CREATE VIEW vw_current_rooms_tenants AS
                SELECT 
                    RO.room_id AS 'Room ID',
                    MAX(RPR.rp_price) AS 'Room Price',
                    vw.`Current Availability` AS 'Availability', 
                    RO.room_floor AS 'Floor', 
                    RO.room_max_renters AS 'Max # of Renters',
                    REG.registration_id
                FROM 
                    tbl_room RO
                LEFT JOIN 
                    vw_current_rooms_availability vw ON RO.room_id = vw.`Room ID`
                LEFT JOIN 
                    tbl_registration REG ON RO.room_id = REG.room_id
                LEFT JOIN 
                    tbl_renter R ON REG.renter_id = R.renter_id
                LEFT JOIN 
                    tbl_movein MI ON R.renter_id = MI.renter_id
                LEFT JOIN 
                    (
                        SELECT 
                            room_id, 
                            rp_price,
                            rp_date
                        FROM (
                            SELECT 
                                room_id, 
                                rp_price,
                                rp_date,
                                ROW_NUMBER() OVER (PARTITION BY room_id ORDER BY rp_id DESC) AS rn
                            FROM 
                                tbl_room_price_record
                            WHERE 
                                rp_date <= CURRENT_DATE
                        ) AS ranked_prices
                        WHERE 
                            rn = 1
                    ) RPR ON RO.room_id = RPR.room_id
                WHERE 
                    vw.`Current Availability` <> 'REMOVED'
                GROUP BY 
                    RO.room_id;


                CREATE VIEW vw_current_rooms AS
                SELECT
	                `Room ID`,
	                `Room Price`,
	                `Max # of Renters`,
	                `Floor`,
	                `Availability`
                FROM
	                vw_current_rooms_tenants;
	

                CREATE VIEW vw_renters_profile AS
                SELECT 
                    R.Registration_ID AS 'Registration ID',
                    R.Renter_ID AS 'Renter ID',
                    RT.renter_fname AS 'First Name',
                    RT.renter_mname AS 'Middle Name',
                    RT.renter_lname AS 'Last Name',
                    RT.renter_contact AS 'Contact #',
                    RT.renter_dob AS 'Date of Birth',
                    RT.renter_address AS 'Address',
                    R.Room_ID AS 'Room ID',
                    D.Deposit_total AS 'Total Deposit',
                    MI.MoveIn_date AS 'Movein Date',
                    R.Registration_date AS 'Registration Date'
                FROM 
                    tbl_registration R
                JOIN 
                    tbl_renter RT ON R.Renter_ID = RT.renter_id
                JOIN 
                    tbl_moveIn MI ON R.Renter_ID = MI.Renter_ID
                JOIN 
                    tbl_Deposit D ON R.Deposit_ID = D.Deposit_ID
                LEFT JOIN 
                    tbl_moveOut MO ON R.Renter_ID = MO.Renter_ID
                WHERE 
                    (MO.MoveOut_date IS NULL OR MO.MoveOut_date > CURRENT_DATE());


                CREATE VIEW vw_room_availability_history AS 
                    SELECT 
                     RAR.ra_id AS 'Room Availability ID',
                     R.room_id AS 'Room ID', 
                     RAT.rat_description AS 'Availability', 
                     RPR.rp_price AS 'Room Price', 
                     R.room_max_renters AS 'Max # of Renters', 
                     R.room_floor AS 'Floor', 
                     RAR.ra_date AS 'Date'
                    FROM 
                     tbl_room R 
                    JOIN 
                     tbl_room_price_record RPR ON R.room_id = RPR.room_id 
                    JOIN 
                     tbl_room_availability_record RAR ON R.room_id = RAR.room_id 
                    JOIN 
                     tbl_room_availability_type RAT ON RAR.rat_id = RAT.rat_id;


                    CREATE VIEW vw_room_damage_record AS
                    SELECT
                        RD_id AS 'Room Damage ID',
                        RD.room_id AS 'Room ID',
                        RDT.rdt_description AS 'Damage Type',
                        RD.rd_description AS 'Description',
                        RD.rd_total_damages AS 'Total Damages',
                        RD.rd_date AS 'Date'
                    FROM
                        tbl_room_damage_record RD
                    JOIN
                        tbl_room_damage_type RDT ON RD.rdt_id = RDT.rdt_id;
                    

                     CREATE VIEW vw_room_price_history AS
                     SELECT 
                         p.RP_ID AS 'Room Price ID',
                         p.RP_price AS 'Room Price',
                         p.RP_date AS 'Date',
                         r.Room_ID AS 'Room ID',
                         r.Room_floor AS 'Floor',
                         r.Room_max_renters  AS 'Max # of Renters'
     
                     FROM 
                         tbl_room r
                     JOIN 
                         tbl_room_price_record p ON r.Room_ID = p.Room_ID;

                  CREATE VIEW vw_rooms_current_prices AS 
                    SELECT 
                        `Room ID`,
                        `Room Price`,
                        `Availability`, 
                        `Floor`, 
                        `Max # of Renters`
                    FROM
                        vw_current_rooms_tenants;

                     CREATE VIEW vw_bill_rate_history AS
                    SELECT 
                        BRR.BT_ID AS 'Bill Rate ID',
                        BT.BT_description AS 'Bill Type',
                        BRR.BR_price AS 'Bill Rate',
                        BRR.BR_date AS 'Date'
                    FROM 
                        tbl_Bill_Rate_Record BRR
                    JOIN 
                        tbl_Bill_Type BT ON BT.BT_ID = BRR.BT_ID;


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

                    CREATE VIEW vw_current_tenants AS
                    SELECT 
                        r.room_id AS 'Room ID',
                        vw.`Room Price`,
                        ro.room_floor AS 'Floor',
                        ro.room_max_renters AS 'Max # of Renters',
                        r.registration_id AS 'Registration ID'
                    FROM 
                        tbl_registration r
                    JOIN 
                        tbl_renter rt ON r.renter_id = rt.renter_id
                    JOIN 
                        tbl_room ro ON r.room_id = ro.room_id
                    JOIN
                        vw_rooms_current_prices vw ON r.room_id = vw.`Room ID`  
                    LEFT JOIN 
                        tbl_moveout mo ON r.renter_id = mo.renter_id
                    WHERE 
                        mo.moveout_date IS NULL
                    GROUP BY r.room_id;  
                   


                   CREATE VIEW vw_dpn_total AS
                  SELECT 
                      d.dpn_id, 
                      d.registration_id AS 'Registration ID',
                      reg.room_id AS 'Room ID',
		          (SELECT rp_price 
                           FROM tbl_room_price_record 
                           WHERE room_id = r.room_id 
                             AND rp_date <= d.dpn_date_issued 
                           ORDER BY rp_date DESC 
                           LIMIT 1) AS 'Room Price', 
			    d.dpn_is_deposit_used as 'Is Deposit Used', 
			     (CASE 
                              WHEN d.dpn_is_deposit_used 
                              THEN -(COALESCE(dep.deposit_total, 0) - (
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
                                  )) 
                              ELSE 
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
                          END) AS 'Total',

                          d.dpn_date_month AS 'For the month of', 
                          d.dpn_date_issued AS 'DPN Date Issued' 
                                           
                      FROM 
                          tbl_dpn d 
                      INNER JOIN tbl_registration reg ON d.registration_id = reg.registration_id 
                      INNER JOIN tbl_renter rt ON reg.renter_id = rt.renter_id
                      INNER JOIN tbl_movein m ON rt.renter_id = m.renter_id
                      INNER JOIN tbl_room r ON reg.room_id = r.room_id
                      INNER JOIN tbl_deposit dep ON reg.deposit_id = dep.deposit_id
                      GROUP BY reg.registration_id;


                    CREATE VIEW vw_receipt_is_fully_paid AS  
                    SELECT    
                        r.receipt_id,  
                        r.dpn_id,  
                        r.receipt_amount_paid,  
                        r.receipt_date_issued, 
                        CASE    
                            WHEN r.receipt_amount_paid >= (d.Total) THEN 1   
                            ELSE 0   
                        END AS receipt_is_fully_paid  
                    FROM   
                        tbl_receipt r  
                    JOIN  
                       vw_dpn_total d ON r.dpn_id = d.dpn_ID; 

                    CREATE VIEW vw_receipt_history AS
                    SELECT 
                        r.receipt_id AS 'Receipt ID',
                        r.dpn_id AS 'DPN ID',
                        d.registration_id AS 'Registration ID',
                        reg.room_id AS 'Room ID',
                        r.receipt_amount_paid AS 'Amount Paid',
                    CASE 
                            WHEN r.receipt_is_fully_paid = 1 THEN 'Fully Paid'
                            ELSE 'Not Fully Paid'
                        END AS 'Payment Status',
                        r.receipt_date_issued AS 'Date Issued'
                    FROM 
                        vw_receipt_is_fully_paid r
                    JOIN 
                        tbl_dpn d ON r.dpn_id = d.dpn_id
                    JOIN 
                        tbl_registration reg ON d.registration_id = reg.registration_id;


                     CREATE VIEW vw_bills_history AS
                    SELECT 
                        b.bill_id AS 'Bill ID',
                        d.dpn_id AS 'DPN ID',
                        r.registration_id AS 'Registration ID',
                        r.room_id AS 'Room ID',
                        bt.bt_description AS 'Bill Type',
                        b.bill_meter_start_month AS 'Meter Start Month',
                        b.bill_meter_end_month AS 'Meter End Month',
                        vw.bill_rate AS 'Bill Rate',
                        vw.bill_total AS 'Bill Total',
                        d.dpn_date_month AS 'Date Issued',
                        d.dpn_date_issued AS 'For the month of'
                    FROM 
                        tbl_bill b
                    JOIN 
                        tbl_dpn d ON b.dpn_id = d.dpn_id
                    JOIN 
                        tbl_bill_type bt ON b.bt_id = bt.bt_id
                    JOIN
                        tbl_registration r ON d.registration_id = r.registration_id
                    JOIN
                        vw_bill_total vw ON b.bill_id = vw.bill_id;

                    CREATE VIEW vw_other_charges_history AS
                    SELECT 
                        oc.oc_id AS 'Other Charges ID', 
                        d.dpn_id AS 'DPN ID',
                        d.registration_id AS 'Registration ID',
                        reg.room_id AS 'Room ID',
                        oc.oc_description AS 'Description',
                        oc.oc_total AS 'Other Charges Total',
                        d.dpn_date_issued AS 'Date Issued',
                        d.dpn_date_month AS 'For the month of'
                    FROM 
                        tbl_other_charges oc
                    JOIN 
                        tbl_dpn d ON oc.dpn_id = d.dpn_id
                    JOIN 
                        tbl_registration reg ON d.registration_id = reg.registration_id;


                     CREATE VIEW vw_renters_profile AS
                    SELECT 
                        REG.registration_id AS 'Registration ID',
                        R.renter_id AS 'Renter ID',
                        R.renter_fname AS 'First Name',
                        R.renter_mname AS 'Middle Name',
                        R.renter_lname AS 'Last Name',
                        R.renter_contact AS 'Contact #',
                        R.renter_dob AS 'DOB',
                        R.renter_address AS 'Address',
                        RO.room_id AS 'Room ID',
                        MI.movein_total_deposit_paid AS 'Deposit Paid',
                        MI.movein_date AS 'Move In Date',
                        REG.registration_date AS 'Registration Date'
                    FROM 
                        tbl_renter R
                    JOIN 
                        tbl_registration REG ON R.renter_id = REG.renter_id
                    JOIN 
                        tbl_room RO ON REG.room_id = RO.room_id
                    JOIN 
                        tbl_movein MI ON REG.movein_id = MI.movein_id
                    JOIN 
                        tbl_room_availability_record RAR ON RO.room_id = RAR.room_id
                    JOIN 
                        tbl_room_availability_type RAT ON RAR.rat_id = RAT.rat_id
                    WHERE 
                        RAT.rat_description IN ('occupied', 'reserved')
                    GROUP BY 
                        reg.registration_id; 

                   
            
        
                    

                     
                "
                ;

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
                string createRecordsQuery = @"
                    insert into tbl_room_availability_type values(1,'Unoccupied');
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
                MessageBox.Show("Record inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting record: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        public static void updateRecord(string table, string setValuePairs, string condition)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }

                string updateQuery = $"UPDATE {table} SET {setValuePairs} WHERE {condition};";
                executeQuery(cnn, updateQuery);
                MessageBox.Show("Record updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message);
            }
            finally
            {
                cnn.Close();
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