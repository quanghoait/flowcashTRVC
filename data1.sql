CREATE DATABASE ManagerFlowMonneyTrad;
USE ManagerFlowMonneyTrad;
CREATE TABLE  User( ID  INT(11) AUTO_INCREMENT, Username varchar (150) DEFAULT NULL, Password varchar(150) DEFAULT NULL, quyen INT (11) DEFAULT NULL, PRIMARY KEY (ID) ); 
INSERT INTO User ( Username,Password,quyen) VALUES ("QuangCuong","cuong123",1);
SELECT * FROM User; 
DROP TABLE User;