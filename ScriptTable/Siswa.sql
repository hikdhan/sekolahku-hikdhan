﻿CREATE TABLE Siswa(
  SiswaId VARCHAR(5) NOT NULL DEFAULT(''), 
  SiswaName VARCHAR(50) NOT NULL DEFAULT(''), 
  TglLahir DATETIME NOT NULL DEFAULT('3000-01-01'), 
  Alamat VARCHAR(50) NOT NULL DEFAULT(''), 
  Alamat2 VARCHAR(50) NOT NULL DEFAULT(''), 
  Kota VARCHAR(20) NOT NULL DEFAULT('')
  
  CONSTRAINT PK_Siswa PRIMARY KEY CLUSTERED(SiswaId)
)