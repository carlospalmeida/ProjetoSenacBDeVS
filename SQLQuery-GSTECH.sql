create database GSTech
go
use GStech
go
create schema GS authorization dbo
go

create table GS.entrega
(
GS_CD			int primary key identity(1,1),
GS_NM			varchar(40),
GS_fone			varchar(20),
GS_email		varchar(40),
GS_endereço		varchar(40),
GS_cep			varchar(15),
GS_região		varchar(40),
GS_país			varchar(20),
GS_Pro			varchar(50),
)
go

insert into GS.entrega values ('José costa','(12) 98151-3245','jose@gmail.com','Rua fernandes','1344562000','Interior de sp','Brasil','Placa de video(rtx 4090')
insert into GS.entrega values ('MedTECH','(11) 9991-9873','Med@gmail.com','Rua jose da costa neto','122324546','Capital de SP','Brasil','20xNotbooks,100xCaixa de cabos utp cat5.e de 100m')
insert into GS.entrega values ('Henrique','(12) 9876-9888','henricao@gmail.com','Rua sangiro tnaka','34665893','Interior de SP','Brasil','20xDesktops asus')
go

select *
from GS.entrega
