if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK') and o.name = 'FK_BOOK_PUBLISH_PUBLISHE')
alter table BOOK
   drop constraint FK_BOOK_PUBLISH_PUBLISHE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK') and o.name = 'FK_BOOK_WRITE_AUTHOR')
alter table BOOK
   drop constraint FK_BOOK_WRITE_AUTHOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKCOPY') and o.name = 'FK_BOOKCOPY_HAS_BOOK')
alter table BOOKCOPY
   drop constraint FK_BOOKCOPY_HAS_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROW') and o.name = 'FK_BORROW_BORROW_STUDENT')
alter table BORROW
   drop constraint FK_BORROW_BORROW_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROW') and o.name = 'FK_BORROW_BORROW2_BOOK')
alter table BORROW
   drop constraint FK_BORROW_BORROW2_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"BROWSE"') and o.name = 'FK_BROWSE_BROWSE_STUDENT')
alter table "BROWSE"
   drop constraint FK_BROWSE_BROWSE_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"BROWSE"') and o.name = 'FK_BROWSE_BROWSE4_BOOK')
alter table "BROWSE"
   drop constraint FK_BROWSE_BROWSE4_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BROWSE2') and o.name = 'FK_BROWSE2_BROWSE2_ADMIN')
alter table BROWSE2
   drop constraint FK_BROWSE2_BROWSE2_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BROWSE2') and o.name = 'FK_BROWSE2_BROWSE3_BOOK')
alter table BROWSE2
   drop constraint FK_BROWSE2_BROWSE3_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MODERATE') and o.name = 'FK_MODERATE_MODERATE_ADMIN')
alter table MODERATE
   drop constraint FK_MODERATE_MODERATE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MODERATE') and o.name = 'FK_MODERATE_MODERATE2_BOOK')
alter table MODERATE
   drop constraint FK_MODERATE_MODERATE2_BOOK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AUTHOR')
            and   type = 'U')
   drop table AUTHOR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK')
            and   name  = 'PUBLISH_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK.PUBLISH_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK')
            and   name  = 'WRITE_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK.WRITE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK')
            and   type = 'U')
   drop table BOOK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKCOPY')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKCOPY.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOKCOPY')
            and   type = 'U')
   drop table BOOKCOPY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BORROW')
            and   name  = 'BORROW2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BORROW.BORROW2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BORROW')
            and   name  = 'BORROW_FK'
            and   indid > 0
            and   indid < 255)
   drop index BORROW.BORROW_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BORROW')
            and   type = 'U')
   drop table BORROW
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"BROWSE"')
            and   name  = 'BROWSE4_FK'
            and   indid > 0
            and   indid < 255)
   drop index "BROWSE".BROWSE4_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"BROWSE"')
            and   name  = 'BROWSE_FK'
            and   indid > 0
            and   indid < 255)
   drop index "BROWSE".BROWSE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"BROWSE"')
            and   type = 'U')
   drop table "BROWSE"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BROWSE2')
            and   name  = 'BROWSE3_FK'
            and   indid > 0
            and   indid < 255)
   drop index BROWSE2.BROWSE3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BROWSE2')
            and   name  = 'BROWSE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BROWSE2.BROWSE2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BROWSE2')
            and   type = 'U')
   drop table BROWSE2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MODERATE')
            and   name  = 'MODERATE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index MODERATE.MODERATE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MODERATE')
            and   name  = 'MODERATE_FK'
            and   indid > 0
            and   indid < 255)
   drop index MODERATE.MODERATE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MODERATE')
            and   type = 'U')
   drop table MODERATE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PUBLISHER')
            and   type = 'U')
   drop table PUBLISHER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STUDENT')
            and   type = 'U')
   drop table STUDENT
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ADMIN_ID             int                  identity,
   ADMIN_NAME           varchar(50)          null,
   EMAIL                varchar(100)         null,
   constraint PK_ADMIN primary key (ADMIN_ID)
)
go

/*==============================================================*/
/* Table: AUTHOR                                                */
/*==============================================================*/
create table AUTHOR (
   AUTHOR_ID            int                  identity,
   AUTHOR_AGE           int                  null,
   AUTHOR_NATIONALITY   varchar(50)          null,
   AUTHOR_NAME          varchar(50)          not null,
   constraint PK_AUTHOR primary key (AUTHOR_ID)
)
go

/*==============================================================*/
/* Table: BOOK                                                  */
/*==============================================================*/
create table BOOK (
   BOOK_ID              int                  identity,
   AUTHOR_ID            int                  not null,
   PUB_NAME             varchar(50)          not null,
   BOOK_TITLE           varchar(100)         not null,
   BOOK_PRICE           int                  null,
   BOOK_GENRE           varchar(50)          null,
   BOOK_EDITION         varchar(50)          null,
   BOOK_LANGUAGE        varchar(50)          null,
   BOOK_COPIESNUM       int                  null,
   PUBLISHED_YEAR       int                  null,
   constraint PK_BOOK primary key (BOOK_ID)
)
go

/*==============================================================*/
/* Index: WRITE_FK                                              */
/*==============================================================*/




create nonclustered index WRITE_FK on BOOK (AUTHOR_ID ASC)
go

/*==============================================================*/
/* Index: PUBLISH_FK                                            */
/*==============================================================*/




create nonclustered index PUBLISH_FK on BOOK (PUB_NAME ASC)
go

/*==============================================================*/
/* Table: BOOKCOPY                                              */
/*==============================================================*/
create table BOOKCOPY (
   BOOK_ID              int                  not null,
   COPY_ID              int                  null,
   AVAILABILITY         bit                  null
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/




create nonclustered index HAS_FK on BOOKCOPY (BOOK_ID ASC)
go

/*==============================================================*/
/* Table: BORROW                                                */
/*==============================================================*/
create table BORROW (
   STUD__ID             int                  not null,
   BOOK_ID              int                  not null,
   BORROW_ID2           int                  null,
   BORROW_DATE          datetime             null,
   DUE_DATE             datetime             null,
   LATE_FEE             int                  null,
   constraint PK_BORROW primary key (STUD__ID, BOOK_ID)
)
go

/*==============================================================*/
/* Index: BORROW_FK                                             */
/*==============================================================*/




create nonclustered index BORROW_FK on BORROW (STUD__ID ASC)
go

/*==============================================================*/
/* Index: BORROW2_FK                                            */
/*==============================================================*/




create nonclustered index BORROW2_FK on BORROW (BOOK_ID ASC)
go

/*==============================================================*/
/* Table: "BROWSE"                                              */
/*==============================================================*/
create table "BROWSE" (
   STUD__ID             int                  not null,
   BOOK_ID              int                  not null,
   constraint PK_BROWSE primary key (STUD__ID, BOOK_ID)
)
go

/*==============================================================*/
/* Index: BROWSE_FK                                             */
/*==============================================================*/




create nonclustered index BROWSE_FK on "BROWSE" (STUD__ID ASC)
go

/*==============================================================*/
/* Index: BROWSE4_FK                                            */
/*==============================================================*/




create nonclustered index BROWSE4_FK on "BROWSE" (BOOK_ID ASC)
go

/*==============================================================*/
/* Table: BROWSE2                                               */
/*==============================================================*/
create table BROWSE2 (
   ADMIN_ID             int                  not null,
   BOOK_ID              int                  not null,
   constraint PK_BROWSE2 primary key (ADMIN_ID, BOOK_ID)
)
go

/*==============================================================*/
/* Index: BROWSE2_FK                                            */
/*==============================================================*/




create nonclustered index BROWSE2_FK on BROWSE2 (ADMIN_ID ASC)
go

/*==============================================================*/
/* Index: BROWSE3_FK                                            */
/*==============================================================*/




create nonclustered index BROWSE3_FK on BROWSE2 (BOOK_ID ASC)
go

/*==============================================================*/
/* Table: MODERATE                                              */
/*==============================================================*/
create table MODERATE (
   ADMIN_ID             int                  not null,
   BOOK_ID              int                  not null,
   constraint PK_MODERATE primary key (ADMIN_ID, BOOK_ID)
)
go

/*==============================================================*/
/* Index: MODERATE_FK                                           */
/*==============================================================*/




create nonclustered index MODERATE_FK on MODERATE (ADMIN_ID ASC)
go

/*==============================================================*/
/* Index: MODERATE2_FK                                          */
/*==============================================================*/




create nonclustered index MODERATE2_FK on MODERATE (BOOK_ID ASC)
go

/*==============================================================*/
/* Table: PUBLISHER                                             */
/*==============================================================*/
create table PUBLISHER (
   PUB_NAME             varchar(50)          not null,
   PUB_EMAIL            varchar(50)          null,
   constraint PK_PUBLISHER primary key (PUB_NAME)
)
go

/*==============================================================*/
/* Table: STUDENT                                               */
/*==============================================================*/
create table STUDENT (
   STUD_FNAME           varchar(50)          not null,
   STUD_LNAME           varchar(50)          not null,
   EMAIL                varchar(100)         null,
   STUD_PHONENUM        varchar(100)         null,
   STUD_BDATE           datetime             null,
   STUD__ID             int                  identity,
   STUD_FACULTY         varchar(100)         null,
   STUD_AGE             int                  null,
   constraint PK_STUDENT primary key (STUD__ID)
)
go

alter table BOOK
   add constraint FK_BOOK_PUBLISH_PUBLISHE foreign key (PUB_NAME)
      references PUBLISHER (PUB_NAME)
go

alter table BOOK
   add constraint FK_BOOK_WRITE_AUTHOR foreign key (AUTHOR_ID)
      references AUTHOR (AUTHOR_ID)
go

alter table BOOKCOPY
   add constraint FK_BOOKCOPY_HAS_BOOK foreign key (BOOK_ID)
      references BOOK (BOOK_ID)
go

alter table BORROW
   add constraint FK_BORROW_BORROW_STUDENT foreign key (STUD__ID)
      references STUDENT (STUD__ID)
go

alter table BORROW
   add constraint FK_BORROW_BORROW2_BOOK foreign key (BOOK_ID)
      references BOOK (BOOK_ID)
go

alter table "BROWSE"
   add constraint FK_BROWSE_BROWSE_STUDENT foreign key (STUD__ID)
      references STUDENT (STUD__ID)
go

alter table "BROWSE"
   add constraint FK_BROWSE_BROWSE4_BOOK foreign key (BOOK_ID)
      references BOOK (BOOK_ID)
go

alter table BROWSE2
   add constraint FK_BROWSE2_BROWSE2_ADMIN foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table BROWSE2
   add constraint FK_BROWSE2_BROWSE3_BOOK foreign key (BOOK_ID)
      references BOOK (BOOK_ID)
go

alter table MODERATE
   add constraint FK_MODERATE_MODERATE_ADMIN foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table MODERATE
   add constraint FK_MODERATE_MODERATE2_BOOK foreign key (BOOK_ID)
      references BOOK (BOOK_ID)
go

INSERT INTO AUTHOR (AUTHOR_AGE, AUTHOR_NATIONALITY, AUTHOR_NAME) VALUES
(45, 'American', 'John Smith'),
(38, 'British', 'Emily Johnson'),
(50, 'Canadian', 'Michael Brown'),
(42, 'Australian', 'Sarah Davis'),
(33, 'Indian', 'Amit Patel'),
(47, 'French', 'Marie Dubois'),
(39, 'Italian', 'Giovanni Rossi'),
(55, 'Japanese', 'Hiroshi Yamamoto'),
(29, 'Brazilian', 'Ana Silva'),
(40, 'Mexican', 'Carlos Garcia'),
(36, 'German', 'Hans Müller'),
(41, 'Russian', 'Olga Ivanova'),
(43, 'Chinese', 'Li Wei'),
(37, 'South African', 'Nandi Nkosi'),
(44, 'Swedish', 'Lars Svensson');

INSERT INTO PUBLISHER (PUB_NAME, PUB_EMAIL) VALUES
('Penguin Books', 'contact@penguin.com'),
('HarperCollins', 'info@harpercollins.com'),
('Simon & Schuster', 'support@simonandschuster.com'),
('Hachette Livre', 'info@hachette.com'),
('Macmillan Publishers', 'contact@macmillan.com'),
('Scholastic', 'info@scholastic.com'),
('Oxford University Press', 'support@oup.com'),
('Cambridge University Press', 'contact@cambridge.org'),
('Springer', 'info@springer.com'),
('Wiley', 'support@wiley.com');

INSERT INTO book (AUTHOR_ID, PUB_NAME, BOOK_TITLE, book_price, book_genre, book_edition, BOOK_LANGUAGE, BOOK_COPIESNUM, PUBLISHED_YEAR) VALUES
(1, 'Penguin Books', 'The Great Adventure', 19.99, 'Adventure', 'First', 'English', 4, 2010),
(2, 'HarperCollins', 'Mystery of the Old Manor', 14.99, 'Mystery', 'Second', 'English', 5, 2015),
(3, 'Simon & Schuster', 'The Science of Everything', 29.99, 'Science', 'Third', 'English', 3, 2020),
(4, 'Hachette Livre', 'Historical Perspectives', 24.99, 'History', 'First', 'English', 3, 2018),
(5, 'Macmillan Publishers', 'Modern Romance', 12.99, 'Romance', 'First', 'English', 4, 2012),
(6, 'Scholastic', 'Fantasy Worlds', 17.99, 'Fantasy', 'Second', 'English', 5, 2019),
(7, 'Oxford University Press', 'Advanced Mathematics', 39.99, 'Education', 'Fourth', 'English', 3, 2016),
(8, 'Cambridge University Press', 'Physics for Everyone', 34.99, 'Science', 'Second', 'English', 4, 2017),
(9, 'Springer', 'Artificial Intelligence Basics', 49.99, 'Technology', 'First', 'English', 5, 2021),
(10, 'Wiley', 'Psychology 101', 27.99, 'Psychology', 'Third', 'English', 3, 2019),
(11, 'Penguin Books', 'Cooking with Passion', 22.99, 'Cooking', 'First', 'English', 4, 2014),
(12, 'HarperCollins', 'Gardening Tips', 15.99, 'Lifestyle', 'Second', 'English', 5, 2013),
(13, 'Simon & Schuster', 'The Universe Explained', 31.99, 'Science', 'Third', 'English', 3, 2020),
(14, 'Hachette Livre', 'Art Through the Ages', 24.99, 'Art', 'First', 'English', 4, 2015),
(15, 'Macmillan Publishers', 'Childrens Tales', 12.99, 'Children', 'First', 'English', 4, 2011),
(12, 'Scholastic', 'Teenage Drama', 18.99, 'Young Adult', 'Second', 'English', 5, 2017),
(10, 'Oxford University Press', 'World History', 35.99, 'History', 'Fourth', 'English', 3, 2018),
(8, 'Cambridge University Press', 'Chemistry in Depth', 33.99, 'Science', 'Second', 'English', 4, 2017),
(10, 'Springer', 'Robotics for Beginners', 45.99, 'Technology', 'First', 'English', 5, 2021),
(1, 'Wiley', 'Sociology Insights', 28.99, 'Sociology', 'Third', 'English', 3, 2019),
(5, 'Penguin Books', 'Adventure in the Wild', 20.99, 'Adventure', 'First', 'English', 4, 2010),
(3, 'HarperCollins', 'Secrets of the Ocean', 16.99, 'Mystery', 'Second', 'English', 5, 2016),
(1, 'Simon & Schuster', 'Understanding Biology', 29.99, 'Science', 'Third', 'English', 3, 2020),
(9, 'Hachette Livre', 'Medieval Legends', 24.99, 'History', 'First', 'English', 4, 2018),
(13, 'Macmillan Publishers', 'Modern Love Stories', 13.99, 'Romance', 'First', 'English', 4, 2012),
(15, 'Scholastic', 'Magical Creatures', 18.99, 'Fantasy', 'Second', 'English', 5, 2019),
(14, 'Oxford University Press', 'Calculus Made Easy', 39.99, 'Education', 'Fourth', 'English', 3, 2016),
(12, 'Cambridge University Press', 'Basics of Quantum Physics', 34.99, 'Science', 'Second', 'English', 4, 2017),
(1, 'Springer', 'Machine Learning Fundamentals', 50.99, 'Technology', 'First', 'English', 5, 2021),
(4, 'Wiley', 'Developmental Psychology', 28.99, 'Psychology', 'Third', 'English', 3, 2019);

INSERT INTO BookCopy (Book_ID, Copy_ID, Availability) VALUES
(1, 1, 1), (1, 2, 1), (1, 3, 1), (1, 4, 1),
(2, 5, 1), (2, 6, 1), (2, 7, 1),
(3, 8, 1), (3, 9, 1), (3, 10, 1), (3, 11, 1), (3, 12, 1),
(4, 13, 1), (4, 14, 1), (4, 15, 1), (4, 16, 1),
(5, 17, 1), (5, 18, 1), (5, 19, 1), (5, 20, 1), (5, 21, 1),
(6, 22, 1), (6, 23, 1), (6, 24, 1),
(7, 25, 1), (7, 26, 1), (7, 27, 1), (7, 28, 1),
(8, 29, 1), (8, 30, 1), (8, 31, 1), (8, 32, 1), (8, 33, 1),
(9, 34, 1), (9, 35, 1), (9, 36, 1),
(10, 37, 1), (10, 38, 1), (10, 39, 1), (10, 40, 1),
(11, 41, 1), (11, 42, 1), (11, 43, 1), (11, 44, 1), (11, 45, 1),
(12, 46, 1), (12, 47, 1), (12, 48, 1),
(13, 49, 1), (13, 50, 1), (13, 51, 1), (13, 52, 1),
(14, 53, 1), (14, 54, 1), (14, 55, 1), (14, 56, 1), (14, 57, 1),
(15, 58, 1), (15, 59, 1), (15, 60, 1)

INSERT INTO borrow (STUD__ID, BOOK_ID, BORROW_ID2, BORROW_DATE, DUE_DATE, LATE_FEE) VALUES
(1, 1, 1001, '2024-01-10', '2024-01-24', 10.0),
(2, 2, 1002, '2024-01-11', '2024-01-25', 15.0),
(3, 3, 1003, '2024-01-12', '2024-01-26', 12.0),
(4, 4, 1004, '2024-01-13', '2024-01-27', 18.0),
(5, 5, 1005, '2024-01-14', '2024-01-28', 10.0),
(6, 6, 1006, '2024-01-15', '2024-01-29', 17.0),
(7, 7, 1007, '2024-01-16', '2024-01-30', 11.0),
(8, 8, 1008, '2024-01-17', '2024-01-31', 19.0),
(9, 9, 1009, '2024-01-18', '2024-02-01', 14.0),
(10, 10, 1010, '2024-01-19', '2024-02-02', 20.0),
(11, 11, 1011, '2024-01-20', '2024-02-03', 13.0),
(12, 12, 1012, '2024-01-21', '2024-02-04', 15.0),
(13, 13, 1013, '2024-01-22', '2024-02-05', 16.0),
(14, 14, 1014, '2024-01-23', '2024-02-06', 18.0),
(15, 15, 1015, '2024-01-24', '2024-02-07', 14.0),
(16, 16, 1016, '2024-01-25', '2024-02-08', 17.0),
(17, 17, 1017, '2024-01-26', '2024-02-09', 11.0),
(18, 18, 1018, '2024-01-27', '2024-02-10', 20.0),
(19, 19, 1019, '2024-01-28', '2024-02-11', 13.0),
(20, 20, 1020, '2024-01-29', '2024-02-12', 19.0);

INSERT INTO STUDENT (STUD_FNAME, STUD_LNAME, EMAIL, STUD_PHONENUM, STUD_BDATE, STUD_FACULTY, STUD_AGE) VALUES
('Alice', 'Johnson', 'alice.johnson@example.com', '555-1234', '2002-05-15', 'Science', 22),
('Bob', 'Smith', 'bob.smith@example.com', '555-2345', '2001-07-20', 'Arts', 23),
('Carol', 'Williams', 'carol.williams@example.com', '555-3456', '2003-01-30', 'Engineering', 21),
('David', 'Jones', 'david.jones@example.com', '555-4567', '2002-03-12', 'Business', 22),
('Eve', 'Brown', 'eve.brown@example.com', '555-5678', '2000-09-25', 'Science', 24),
('Frank', 'Taylor', 'frank.taylor@example.com', '555-6789', '2001-11-11', 'Arts', 23),
('Grace', 'Davis', 'grace.davis@example.com', '555-7890', '2002-02-28', 'Engineering', 22),
('Hank', 'Miller', 'hank.miller@example.com', '555-8901', '2003-08-19', 'Business', 21),
('Ivy', 'Wilson', 'ivy.wilson@example.com', '555-9012', '2000-05-30', 'Science', 24),
('Jack', 'Moore', 'jack.moore@example.com', '555-0123', '2001-07-22', 'Arts', 23),
('Kate', 'Thomas', 'kate.thomas@example.com', '555-1235', '2002-01-14', 'Engineering', 22),
('Leo', 'Harris', 'leo.harris@example.com', '555-2346', '2000-10-20', 'Business', 24),
('Mia', 'Clark', 'mia.clark@example.com', '555-3457', '2001-04-15', 'Science', 23),
('Nina', 'Lewis', 'nina.lewis@example.com', '555-4568', '2003-12-05', 'Arts', 21),
('Oscar', 'Walker', 'oscar.walker@example.com', '555-5679', '2002-06-18', 'Engineering', 22),
('Paul', 'Young', 'paul.young@example.com', '555-6780', '2001-11-01', 'Business', 23),
('Quinn', 'Hall', 'quinn.hall@example.com', '555-7891', '2000-08-24', 'Science', 24),
('Rachel', 'Allen', 'rachel.allen@example.com', '555-8902', '2003-03-09', 'Arts', 21),
('Sam', 'King', 'sam.king@example.com', '555-9013', '2002-02-14', 'Engineering', 22),
('Tina', 'Wright', 'tina.wright@example.com', '555-0124', '2001-09-26', 'Business', 23);

INSERT INTO [BROWSE] (stud__id, book_id) VALUES
(1, 1), (2, 2), (3, 3), (4, 4), (5, 5),
(6, 6), (7, 7), (8, 8), (9, 9), (10, 10),
(11, 11), (12, 12), (13, 13), (14, 14), (15, 15),
(16, 16), (17, 17), (18, 18), (19, 19), (20, 20);

INSERT INTO BROWSE2 (admin_id, book_id) VALUES
(1, 1), (2, 2), (3, 3), (4, 4), (5, 5),
(1, 6), (2, 7), (3, 8), (4, 9), (5, 10),
(1, 11), (2, 12), (3, 13), (4, 14), (5, 15);

INSERT INTO ADMIN (admin_name, email) VALUES
('Admin One', 'admin.one@example.com'),
('Admin Two', 'admin.two@example.com'),
('Admin Three', 'admin.three@example.com'),
('Admin Four', 'admin.four@example.com'),
('Admin Five', 'admin.five@example.com');

