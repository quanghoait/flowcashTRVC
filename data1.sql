CREATE DATABASE ManagerFlowMonneyTrad;
USE ManagerFlowMonneyTrad;
CREATE TABLE  employee( ID_employee  INT AUTO_INCREMENT, Username varchar (150) DEFAULT NULL, Password varchar(150) DEFAULT NULL, IDper INT DEFAULT NULL, PRIMARY KEY (ID_employee) ); 
INSERT INTO employee( Username,Password,IDper) VALUES ("QuangCuong","cuong123",1);
INSERT INTO employee( Username,Password,IDper) VALUES ("PhuongLan","lan123",2);
SELECT Username AS LargestPrice FROM employee where ID_employee = (SELECT MAX(ID_employee)  FROM employee) ;
SELECT * FROM employee; 
SELECT * FROM employee where Username ="PhuongLan" and Password ="lan123";
DROP TABLE employee;
CREATE TABLE  CodeTable( ID  INT AUTO_INCREMENT, S_code varchar (150) DEFAULT NULL, F varchar(150) DEFAULT NULL, ItemName varchar(150) DEFAULT NULL,the_kind varchar(150) DEFAULT NULL,Account_No varchar(150) DEFAULT NULL,Bank varchar(150) DEFAULT NULL,Type varchar(150) DEFAULT NULL,  PRIMARY KEY (ID) ); 
INSERT INTO CodeTable( S_code,F,ItemName,the_kind,Account_No,Bank,Type) VALUES ("HC001","Ha Nam Customs Office","Import tax","Goverment office","","Ngan hang TMCP Ngoai Thuong Viet Nam, CN Ha Nam","Monthly");
INSERT INTO CodeTable( S_code,F,ItemName,the_kind,Account_No,Bank,Type) VALUES ("HC002","Ha Nam Customs Office","Import tax","Goverment office","","Ngan hang TMCP Ngoai Thuong Viet Nam, CN Ha Nam","Monthly");

INSERT INTO employee( Username,Password,IDper) VALUES ("PhuongLan","lan123",2);
SELECT * FROM CodeTable; 
DROP TABLE CodeTable;
CREATE TABLE  CashBook(
ID_CashBook  INT AUTO_INCREMENT,
Ma varchar(150) Not NULL,
  Date_Cash date Not NULL,
 Decscription varchar(200) Not NULL,
 Income float  DEFAULT NULL,
 Payment float DEFAULT  NULL,
 Balance  float DEFAULT NULL,
SupplierCode varchar(150) Not NULL,
 SupplierName varchar(150) Not NULL,
 PRIMARY KEY (ID_CashBook) ); 
INSERT INTO CashBook( Ma,Date_Cash,Decscription,Income,Payment,Balance,SupplierCode,SupplierName) VALUES ("TM20242",'2024-02-27',"Receive money from debit note 2310-02- Tax receivable from Takasago",5000,3000,18000,"ksdks","llsjdls");
INSERT INTO CashBook( ID_Cash,Date_Cash,Decscription,Income,Payment,Balance) VALUES (3,'2023-5-25',"Receive money from debit note 2310-02- Tax receivable from Takasago",5000,3000,18000);
INSERT INTO CashBook( ID_Cash,Date_Cash,Decscription,Income,Payment,Balance) VALUES (4,'2024-1-27',"Receive money from debit note 2000-02- Tax receivable from Takasago",6000,1000,12000);
DROP TABLE CashBook;
SELECT * FROM CashBook ;
CREATE TABLE  MaCashTable(ID_Cash  INT AUTO_INCREMENT,MaCash varchar(200) not NULL, NameMa varchar(200) Not NULL, PRIMARY KEY (ID_Cash)); 
INSERT INTO MaCashTable( MaCash,NameMa) VALUES ("TM","Cash");
INSERT INTO MaCashTable( MaCash,NameMa) VALUES ("VD","VND (VIETCOMBANK)");
INSERT INTO MaCashTable( MaCash,NameMa3) VALUES ("MD","H15-795-011595");
INSERT INTO MaCashTable( MaCash,NameMa) VALUES ("MU","F15-795-011587");
INSERT INTO MaCashTable( MaCash,NameMa) VALUES ("MY","F15-795-011919");
SELECT MaCash FROM MaCashTable where NameMa ="H15-795-011595";
SELECT month(Date_Cash)  FROM CashBook where ID_Cash=2;
SELECT year(Date_Cash)  FROM CashBook where ID_Cash=2;
SELECT Balance   FROM CashBook where ID_CashBook = (SELECT max(ID_CashBook)  FROM CashBook);

