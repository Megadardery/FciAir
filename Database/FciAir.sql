--create database FciAir;
use FciAir;

/*==============================================================*/
/* DBMS name:      MySQL 4.0                                    */
/* Created on:     24/4/2019 7:31:53 PM                         */
/* Modified by:    Ahmed Nasr Eldardery                         */
/*==============================================================*/

drop table Tickets;

drop table Monitor;

drop table Customers;

drop table Flights;

drop table Pilots;

drop table Aircrafts;

drop table Admins;

/*==============================================================*/
/* Table: Admins                                                */
/*==============================================================*/
create table Admins
(
   AdminID                      int                            identity(1,1)			  not null,
   FirstName                    varchar(20)                    not null,
   LastName                     varchar(20),
   Username                     varchar(20)                    not null                    unique,
   Password                     char(16)                       not null,
   primary key (AdminID)
);

/*==============================================================*/
/* Table: Aircrafts                                             */
/*==============================================================*/
create table Aircrafts
(
   AircraftID                   int                            identity(1,1)			 not null,
   AdminID                      int                            not null,
   MaxSeats                     int,
   Model                        varchar(20),
   primary key (AircraftID)
);

/*==============================================================*/
/* Table: Customers                                             */
/*==============================================================*/
create table Customers
(
   CustomerID                   int                            identity(1,1)			 not null,
   FirstName                    varchar(20)                    not null,
   LastName                     varchar(20),
   Passport                     int                            not null,
   Nationality                  varchar(20),
   Birthdate                    date,
   Username                     varchar(20)                    not null                    unique,
   Password                     char(16)                       not null,
   primary key (CustomerID)
);

/*==============================================================*/
/* Table: Flights                                               */
/*==============================================================*/
create table Flights
(
   FlightID                     int                            identity(1,1)			 not null,
   AircraftID                   int                            not null,
   DepartTime                   datetime,
   ArriveTime                   datetime,
   RequiredSeats                int,
   Source                       varchar(20),
   Destination                  varchar(20),
   primary key (FlightID)
);

/*==============================================================*/
/* Table: Monitor                                               */
/*==============================================================*/
create table Monitor
(
   AdminID                      int                            not null,
   FlightID                     int                            not null,
   primary key (AdminID, FlightID)
);

/*==============================================================*/
/* Table: Pilots                                                */
/*==============================================================*/
create table Pilots
(
   AircraftID                   int                            not null,
   Name                         varchar(20)                    not null,
   Birthdate                    date,
   Salary                       float(8),
   primary key (AircraftID)
);

/*==============================================================*/
/* Table: Tickets                                               */
/*==============================================================*/
create table Tickets
(
   TicketID                     int                            identity(1,1)			 not null,
   FlightID                     int                            not null,
   CustomerID                   int                            not null,
   Price						int							   not null,
   AgeGroup						varchar(20),
   Class                        varchar(20),
   BookDate                     datetime,
   primary key (TicketID)
);

alter table Aircrafts add constraint FK_ADD foreign key (AdminID)
      references Admins (AdminID);

alter table Flights add constraint FK_HAVE foreign key (AircraftID)
      references Aircrafts (AircraftID);

alter table Monitor add constraint FK_Monitor foreign key (AdminID)
      references Admins (AdminID);

alter table Monitor add constraint FK_Monitor2 foreign key (FlightID)
      references Flights (FlightID);

alter table Pilots add constraint FK_DRIVENBY foreign key (AircraftID)
      references Aircrafts (AircraftID);

alter table Tickets add constraint FK_BOOK foreign key (CustomerID)
      references Customers (CustomerID);

alter table Tickets add constraint FK_FOR foreign key (FlightID)
      references Flights (FlightID);

