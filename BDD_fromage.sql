DROP DATABASE IF EXISTS Fromage;
CREATE DATABASE Fromage;
USE Fromage;

create table pays(
id int,
nom varchar(100),
primary key (id)
)Engine Innodb;
 
 create table fromage(
id int,
pays_origine_id int,
nom varchar(75),
creation  int,
image varchar(255),
primary key (id),
foreign key(pays_origine_id) References pays(id)
)Engine Innodb;

select * from pays;
select * from fromage;