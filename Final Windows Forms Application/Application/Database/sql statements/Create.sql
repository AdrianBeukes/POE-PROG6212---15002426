USE DFH

CREATE TABLE Appointments
(
	APP_NO			int				IDENTITY(10,1) PRIMARY KEY,
	NAME			varchar(30)		not null,
	SURNAME			varchar(30)		not null,
	PHONE_NUMBER	varchar(15)		not null,
	DATE			Date			not null,
	TIME			Time(0)			not null,
	DESCRIPTION		varchar(250)	null                                                                              
)
