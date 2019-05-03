--create database FciAir;
use FciAir;

/*==============================================================*/
/* DBMS name:      MySQL 4.0                                    */
/* Created on:     24/4/5019 7:31:53 PM                         */
/* Modified by:    Ahmed Nasr Eldardery                         */
/*==============================================================*/

/*==============================================================*/
/* Table: Admins                                                */
/*==============================================================*/
create table Admins
(
   AdminID                      int                            identity(1,1)			  not null,
   FirstName                    varchar(50)                    not null,
   LastName                     varchar(50),
   Username                     varchar(50)                    not null                    unique,
   Password                     char(32)                       not null,
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
   Model                        varchar(50),
   PilotName                         varchar(50)                    not null,
   Birthdate                    date,
   Salary                       float(8),
   primary key (AircraftID)
);

/*==============================================================*/
/* Table: Customers                                             */
/*==============================================================*/
create table Customers
(
   CustomerID                   int                            identity(1,1)			 not null,
   FirstName                    varchar(50)                    not null,
   LastName                     varchar(50),
   Passport                     varchar(50)                    not null,
   Nationality                  varchar(50),
   Birthdate                    date,
   Username                     varchar(50)                    not null                    unique,
   Password                     char(32)                       not null,
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
   Source                       varchar(50),
   Destination                  varchar(50),
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
/* Table: Tickets                                               */
/*==============================================================*/
create table Tickets
(
   TicketID                     int                            identity(1,1)			 not null,
   FlightID                     int                            not null,
   CustomerID                   int                            not null,
   Price						int							   not null,
   AgeGroup						varchar(50),
   Class                        varchar(50),
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

alter table Tickets add constraint FK_BOOK foreign key (CustomerID)
      references Customers (CustomerID);

alter table Tickets add constraint FK_FOR foreign key (FlightID)
      references Flights (FlightID);
