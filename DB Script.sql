CREATe DATABASE Project_20;

-- USERS TABLE
CREATE TABLE users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    hashed_password VARCHAR(255),
    email VARCHAR(50) NOT NULL UNIQUE,
    role ENUM('Admin', 'Farmer', 'Expert') NOT NULL
);

-- FARMER PROFILE
CREATE TABLE farmer_profile (
    farmer_id INT AUTO_INCREMENT PRIMARY KEY,
    
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50),
    cnic CHAR(13) NOT NULL UNIQUE,
    profile_pic VARCHAR(300),
    address VARCHAR(255) NOT NULL,
    contact CHAR(11) NOT NULL,
    email VARCHAR(50) UNIQUE check(email like ('%@% ' or '@gmail.com')),
    dob DATE not null ,
    age INT CHECK (age >= 10),
   foreign key(email) references users(email)
);

-- EXPERT PROFILE
CREATE TABLE expert_profile (
    e_id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) not null,
    last_name VARCHAR(50) ,
    profile_pic VARCHAR(300),
    cnic CHAR(13) UNIQUE not null,
    email VARCHAR(50) UNIQUE check(email like ('%@% ' or '@gmail.com')),
    address VARCHAR(255) not null,
    dob DATE NOT NULL,
    contact CHAR(11) NOT NULL ,
    FOREIGN KEY (email) REFERENCES users(email)
);

-- EDUCATIONAL INFO
CREATE TABLE educational_info (
    edu_id INT AUTO_INCREMENT PRIMARY KEY,
    e_id INT,
    degree_type ENUM('HSC', 'BSc', 'MSc', 'PhD'),
    roll_number VARCHAR(20) not null,
    obtained_marks INT not null,
    total_marks INT not null,
    description VARCHAR(300) not null,
    passing_year INT  not null ,
    degree_pic VARCHAR(255),
    FOREIGN KEY (e_id) REFERENCES expert_profile(e_id)
);
CREATE TABLE vendor_profile (
    vendor_id INT AUTO_INCREMENT PRIMARY KEY,
    farmer_id INT,
    first_name VARCHAR(50) not null,
    last_name VARCHAR(50),
    address VARCHAR(255) not null,
    cnic CHAR(13) UNIQUE not null,
    contact_info CHAR(11) NOT NULL,
    FOREIGN KEY (farmer_id) REFERENCES farmer_profile(farmer_id)
);

-- LAND
CREATE TABLE land (
    land_id INT AUTO_INCREMENT PRIMARY KEY,
    farmer_id INT,
    location VARCHAR(255) not null ,
    area FLOAT not null,
    soil_type VARCHAR(50) not null,
    pic VARCHAR(255) ,
    FOREIGN KEY (farmer_id) REFERENCES farmer_profile(farmer_id)
);

-- CROP
CREATE TABLE crop (
    crop_id INT AUTO_INCREMENT PRIMARY KEY,
    crop_name VARCHAR(50),
    description VARCHAR(255)
);

-- PLANTED CROPS
CREATE TABLE planted_crops (
    p_id INT AUTO_INCREMENT PRIMARY KEY,
    land_id INT,
    farmer_id INT,
    crop_id INT,
    year INT not null,
    season varchar(50) not null,
    area FLOAT not null,
    status varchar(50),
    FOREIGN KEY (land_id) REFERENCES land(land_id),
    FOREIGN KEY (farmer_id) REFERENCES farmer_profile(farmer_id),
    FOREIGN KEY (crop_id) REFERENCES crop(crop_id)
);

-- WATER RESOURCES
CREATE TABLE water_resources (
    w_id INT AUTO_INCREMENT PRIMARY KEY,
    farmer_id int,
    type varchar(50) not null,
    location VARCHAR(100),
    cost_per_hour int not null,
    foreign key(farmer_id) references farmer_profile(farmer_id)
);
CREATE TABLE water_usage (
    wu_id INT AUTO_INCREMENT PRIMARY KEY,
    w_id INT,
    planted_id INT,
    usage_hours FLOAT,
    total_cost FLOAT,
    FOREIGN KEY (w_id) REFERENCES water_resources(w_id),
    FOREIGN KEY (planted_id) REFERENCES planted_crops(p_id)
);
CREATE TABLE equipments (
    eq_id INT AUTO_INCREMENT PRIMARY KEY,
    eq_name VARCHAR(100),
    description VARCHAR(255)
);

-- RENTED EQUIPMENT
CREATE TABLE rented_equipment (
    rental_id INT AUTO_INCREMENT PRIMARY KEY,
    vendor_id INT,
    eq_id INT,
    farmer_id INT,
    model varchar(70) unique not null,
    rental_start_date DATE,
    rental_end_date DATE,
    rental_cost FLOAT,
    description VARCHAR(255),
    CHECK (rental_end_date > rental_start_date),
    FOREIGN KEY (vendor_id) REFERENCES vendor_profile(vendor_id),
    FOREIGN KEY (eq_id) REFERENCES equipments(eq_id),
    FOREIGN KEY (farmer_id) REFERENCES farmer_profile(farmer_id)
);

-- OWNED EQUIPMENT
CREATE TABLE owned_equipment (
    owned_id INT AUTO_INCREMENT PRIMARY KEY,
    eq_id INT,
    farmer_id INT,
     model varchar(70) unique not null,
    status VARCHAR(50),
    cost FLOAT,
    description VARCHAR(255),
    FOREIGN KEY (eq_id) REFERENCES equipments(eq_id),
    FOREIGN KEY (farmer_id) REFERENCES farmer_profile(farmer_id)
);


-- AGRI BATCH
CREATE TABLE agri_batch (
    batch_id INT AUTO_INCREMENT PRIMARY KEY,
    entry_date DATE,
    expiry_date DATE,
    quantity FLOAT,
    company_name VARCHAR(100),
    price_per_unit FLOAT
);

-- AGRI PRODUCTS
CREATE TABLE agri_products (
    agr_id INT AUTO_INCREMENT PRIMARY KEY,
    batch_id INT,
    farmer_id INT,
    name VARCHAR(50),
    type VARCHAR(50),
    location VARCHAR(255),
    FOREIGN KEY (batch_id) REFERENCES agri_batch(batch_id),
    FOREIGN KEY (farmer_id) REFERENCES farmer_profile(farmer_id)
);

-- AGRI USAGE
CREATE TABLE agri_usage (
    agri_usage_id INT AUTO_INCREMENT PRIMARY KEY,
    agr_id INT,
    used_quantity FLOAT,
    description VARCHAR(255),
    planting_id INT,
    FOREIGN KEY (agr_id) REFERENCES agri_products(agr_id),
    FOREIGN KEY (planting_id) REFERENCES planted_crops(p_id)
);

-- CROP BATCH
CREATE TABLE crop_batch (
    batch_id INT AUTO_INCREMENT PRIMARY KEY,
    entry_date DATE,
    exit_date DATE,
    purpose ENUM('Sale', 'Buy', 'Loss', 'Harvested', 'Consumption'),
    quantity FLOAT,
    price FLOAT
);

-- CROP STOCK
CREATE TABLE crop_stock (
    stock_id INT AUTO_INCREMENT PRIMARY KEY,
    crop_batch_id INT,
    crop_name VARCHAR(50),
    category VARCHAR(50),
    location VARCHAR(100),
    FOREIGN KEY (crop_batch_id) REFERENCES crop_batch(batch_id)
);

-- EXPERT RESPONSE
CREATE TABLE expert_response (
    response_id INT AUTO_INCREMENT PRIMARY KEY,
    farmer_id INT,
    expert_id INT,
    response TEXT,
    rating INT CHECK (rating BETWEEN 1 AND 5),
    FOREIGN KEY (farmer_id) REFERENCES farmer_profile(farmer_id),
    FOREIGN KEY (expert_id) REFERENCES expert_profile(e_id)
);

-- FARMER REQUESTS
CREATE TABLE farmer_requests (
    request_id INT AUTO_INCREMENT PRIMARY KEY,
    farmer_id INT,
    expert_id INT,
    request_type VARCHAR(100),
    description TEXT,
    status ENUM('Pending', 'Seen'),
    FOREIGN KEY (farmer_id) REFERENCES farmer_profile(farmer_id),
    FOREIGN KEY (expert_id) REFERENCES expert_profile(e_id)
);

-- FARMER REPORT
CREATE TABLE farmer_report (
    report_id INT AUTO_INCREMENT PRIMARY KEY,
    farmer_id INT,
    expert_id INT,
    report_type VARCHAR(100),
    description TEXT,
    status ENUM('Pending', 'Accepted', 'Rejected'),
    FOREIGN KEY (farmer_id) REFERENCES farmer_profile(farmer_id),
    FOREIGN KEY (expert_id) REFERENCES expert_profile(e_id)
);

-- FARMER SUGGESTIONS
CREATE TABLE farmer_suggestions (
    id INT AUTO_INCREMENT PRIMARY KEY,
    farmer_id INT,
    type VARCHAR(50),
    description TEXT,
    status VARCHAR(50),
    FOREIGN KEY (farmer_id) REFERENCES farmer_profile(farmer_id)
);
DELIMITER //

CREATE TRIGGER calculate_water_usage_cost
BEFORE INSERT ON water_usage
FOR EACH ROW
BEGIN
    DECLARE cost_per_hour_value FLOAT;
    
    -- Get the cost_per_hour from the related water_resource
    SELECT cost_per_hour INTO cost_per_hour_value
    FROM water_resources
    WHERE w_id = NEW.w_id;
    
    -- Calculate the total_cost
    SET NEW.total_cost = NEW.usage_hours * cost_per_hour_value;
END//

CREATE TRIGGER update_water_usage_cost
BEFORE UPDATE ON water_usage
FOR EACH ROW
BEGIN
    DECLARE cost_per_hour_value FLOAT;
    
    -- Get the cost_per_hour from the related water_resource
    SELECT cost_per_hour INTO cost_per_hour_value
    FROM water_resources
    WHERE w_id = NEW.w_id;
    
    -- Calculate the total_cost if either usage_hours or w_id changed
    IF NEW.usage_hours <> OLD.usage_hours OR NEW.w_id <> OLD.w_id THEN
        SET NEW.total_cost = NEW.usage_hours * cost_per_hour_value;
    END IF;
END//

DELIMITER ;
-- TRIGGER: auto calculate age from DOB
DELIMITER //
CREATE TRIGGER trg_calculate_age
BEFORE INSERT ON farmer_profile
FOR EACH ROW
BEGIN
  IF NEW.dob IS NOT NULL THEN
    SET NEW.age = TIMESTAMPDIFF(YEAR, NEW.dob, CURDATE());
  END IF;
END;
//
DELIMITER ;