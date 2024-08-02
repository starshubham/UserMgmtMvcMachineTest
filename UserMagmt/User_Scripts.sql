Create Table States
(
	Id int identity(1,1) primary key,
	StateName varchar(50) not null
)
Select * from States

Insert into States(StateName) Values
('Uttar Pradesh'),
('Delhi'),
('Madhay Pradesh')
Select * from States

Update States set StateName='Madhya Pradesh' where Id=3

Create Table Districts
(
	Id int identity(1,1) primary key,
	DistrictName varchar(50) not null,
	StateId int not null foreign key references States(Id)
)

Insert into Districts(DistrictName,StateId) Values
('Varanasi', 1),
('Jaunpur', 1),
('East Delhi', 2),
('New Delhi', 2),
('Bhopal', 3),
('Indore', 3)
Select * from Districts

Update Districts set DistrictName='Indore' where Id=6

Create Table Users
(
	Id int identity(1,1) primary key,
	UserName varchar(50) not null,
	StateId int not null foreign key references States(Id),
	DistrictId int not null foreign key references Districts(Id)
)
Select * from Users