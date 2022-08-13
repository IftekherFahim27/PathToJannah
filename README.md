# PathToJannah
Create table Dua(
DU_ID int primary key IDENTITY(1,1),
Name varchar(255),
Dua_txt TEXT,
Dua_meaning TEXT,
U_ID int FOREIGN KEY REFERENCES Users(U_ID)


)

Alter table Surah
ADD Surah_meaning TEXT

Alter table Hadith
ADD Hadith_meaning TEXT


select *from Admin

Insert into Admin(Name,email,pass) Values('Eva','adeva@gmail.com','admin123')






Create table Surah(
S_ID int primary key IDENTITY(1,1),
Name varchar(255),
Ayat int,
Origin varchar (255),
Surah_txt TEXT,
U_ID int FOREIGN KEY REFERENCES Users(U_ID)
)

Create table Hadith(
H_ID int primary key IDENTITY(1,1),
Name varchar(255),
Bookname varchar(255) UNIQUE,
hadith_no int,
hadith_text TEXT,
U_ID int FOREIGN KEY REFERENCES Users(U_ID)
)
