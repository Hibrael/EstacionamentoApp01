Create database estacionamento_db;
Use estacionamento_db;

Create table tipo_veiculo
(
id_tipo int primary key not null,
descrição varchar(9) not null
);

Create table Usuario
(
Username varchar(20),
Senha varchar(10)
);
Create table Veiculo 
(
Veiculo_id int primary key auto_increment not null,
Nome varchar(20) not null,
Placa varchar(7) not null unique ,
Modelo varchar(10) not null,
Hora_entrada datetime not null,
Hora_saida datetime,
tipo_id int not null,
tempo_total double,
valor_pago double
);

Alter table veiculo add constraint fk_veiculo_tipo foreign key (tipo_id) references tipo_veiculo (id_tipo) on delete no action on update cascade;
INSERT INTO tipo_veiculo (id_tipo, descrição) values (1, 'moto'), (2, 'carro'), (3, 'camioneta');


