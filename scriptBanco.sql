create database Estacionamento;
use Estacionamento;

create table tipo_Veiculo
(
    id_tipo int not null,
    descrição varchar (10)
);

create table Veiculo 
(
	Veiculo_id int auto_increment not null primary key, 
	Nome varchar(25) not null, 
    Placa varchar(9)  not null unique,
    Modelo varchar(20) not null,
    Hora_entrada datetime not null,
    Hora_Saida datetime,
    tipo_id int not null
);

 INSERT INTO tipo_veiculo (id_tipo, descrição) values (1, 'moto'), (2, 'carro'), (3, 'camioneta');

 alter table tipo_Veiculo add constraint primary key (id_tipo);
Alter table veiculo add constraint fk_veiculo_tipo foreign key (tipo_id) references tipo_veiculo (id_tipo) on delete no action on update cascade 