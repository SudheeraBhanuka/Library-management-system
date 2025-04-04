USE [C:\USERS\SUDHE\ONEDRIVE\DESKTOP\GUI CW\ELIBRARY.MDF]

CREATE TABLE books(
		bookID int PRIMARY KEY identity(1,1),
		bookName varchar(50) NOT NULL,
		author varchar(50) NOT NULL,
		isbn varchar(10) NOT NULL,
		dateofpub varchar(10) NOT NULL
		)

CREATE TABLE members(
		indexNo int PRIMARY KEY identity(100,1),
		memberName varchar(50)  NOT NULL,
		email varchar(50) NOT NULL,
		homrAddress varchar(100) NOT NULL,
		contactNo int NOT NULL
		)

ALTER TABLE books ADD noOfCopies int 

CREATE TABLE users(
		username varchar(20) PRIMARY KEY NOT NULL,
		emailAddress varchar(50) NOT NULL,
		passwordTxt varchar(20) NOT NULL
		)

SELECT * FROM users

USE [C:\USERS\SUDHE\ONEDRIVE\DESKTOP\GUI CW\BIN\DEBUG\TESTELIBRARY.MDF]

CREATE TABLE issuedBooks(
		bookID int FOREIGN KEY REFERENCES books(bookID),
		bookName varchar(50) NOT NULL,
		memberIndex int FOREIGN KEY REFERENCES members(indexNo),
		memberName varchar(50) NOT NULL,
		DateAndTime varchar(20) NOT NULL
		)

SELECT * FROM users
