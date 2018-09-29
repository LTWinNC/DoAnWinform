/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     9/19/2018 8:03:10 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BIENLAI') and o.name = 'FK_BIENLAI_RELATIONS_HOCVIEN')
alter table BIENLAI
   drop constraint FK_BIENLAI_RELATIONS_HOCVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GIAOVIEN_LOPHOC') and o.name = 'FK_GIAOVIEN_GIAOVIEN__GIAOVIEN')
alter table GIAOVIEN_LOPHOC
   drop constraint FK_GIAOVIEN_GIAOVIEN__GIAOVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GIAOVIEN_LOPHOC') and o.name = 'FK_GIAOVIEN_GIAOVIEN__LOPHOC')
alter table GIAOVIEN_LOPHOC
   drop constraint FK_GIAOVIEN_GIAOVIEN__LOPHOC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOCVIEN_LOPHOC') and o.name = 'FK_HOCVIEN__HOCVIEN_L_HOCVIEN')
alter table HOCVIEN_LOPHOC
   drop constraint FK_HOCVIEN__HOCVIEN_L_HOCVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOCVIEN_LOPHOC') and o.name = 'FK_HOCVIEN__HOCVIEN_L_LOPHOC')
alter table HOCVIEN_LOPHOC
   drop constraint FK_HOCVIEN__HOCVIEN_L_LOPHOC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KETQUA') and o.name = 'FK_KETQUA_RELATIONS_HOCVIEN')
alter table KETQUA
   drop constraint FK_KETQUA_RELATIONS_HOCVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LICHHOC') and o.name = 'FK_LICHHOC_RELATIONS_LOPHOC')
alter table LICHHOC
   drop constraint FK_LICHHOC_RELATIONS_LOPHOC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOPHOC') and o.name = 'FK_LOPHOC_RELATIONS_KHOAHOC')
alter table LOPHOC
   drop constraint FK_LOPHOC_RELATIONS_KHOAHOC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BIENLAI')
            and   name  = 'RELATIONSHIP_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index BIENLAI.RELATIONSHIP_4_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BIENLAI')
            and   type = 'U')
   drop table BIENLAI
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GIAOVIEN')
            and   type = 'U')
   drop table GIAOVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GIAOVIEN_LOPHOC')
            and   name  = 'GIAOVIEN_LOPHOC2_FK'
            and   indid > 0
            and   indid < 255)
   drop index GIAOVIEN_LOPHOC.GIAOVIEN_LOPHOC2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GIAOVIEN_LOPHOC')
            and   name  = 'GIAOVIEN_LOPHOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index GIAOVIEN_LOPHOC.GIAOVIEN_LOPHOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GIAOVIEN_LOPHOC')
            and   type = 'U')
   drop table GIAOVIEN_LOPHOC
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOCVIEN')
            and   type = 'U')
   drop table HOCVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOCVIEN_LOPHOC')
            and   name  = 'HOCVIEN_LOPHOC2_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOCVIEN_LOPHOC.HOCVIEN_LOPHOC2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOCVIEN_LOPHOC')
            and   name  = 'HOCVIEN_LOPHOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOCVIEN_LOPHOC.HOCVIEN_LOPHOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOCVIEN_LOPHOC')
            and   type = 'U')
   drop table HOCVIEN_LOPHOC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KETQUA')
            and   name  = 'RELATIONSHIP_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index KETQUA.RELATIONSHIP_3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KETQUA')
            and   type = 'U')
   drop table KETQUA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHOAHOC')
            and   type = 'U')
   drop table KHOAHOC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LICHHOC')
            and   name  = 'RELATIONSHIP_2_FK'
            and   indid > 0
            and   indid < 255)
   drop index LICHHOC.RELATIONSHIP_2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LICHHOC')
            and   type = 'U')
   drop table LICHHOC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOPHOC')
            and   name  = 'RELATIONSHIP_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOPHOC.RELATIONSHIP_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOPHOC')
            and   type = 'U')
   drop table LOPHOC
go

/*==============================================================*/
/* Table: BIENLAI                                               */
/*==============================================================*/
create table BIENLAI (
   MASOBL               nchar(10)            not null,
   MASOHV               nchar(10)            not null,
   MASO_HV              nchar(10)            not null,
   THANHTIEN            money                null,
   MIENGIAM             bit                  null,
   constraint PK_BIENLAI primary key (MASOBL)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_4_FK on BIENLAI (MASOHV ASC)
go

/*==============================================================*/
/* Table: GIAOVIEN                                              */
/*==============================================================*/
create table GIAOVIEN (
   MAGV                 nchar(10)            not null,
   HOTENGV              nvarchar(50)         null,
   NGAYSINHGV           datetime             null,
   SDTGV                nchar(11)            null,
   DIACHIGV             nvarchar(50)         null,
   constraint PK_GIAOVIEN primary key (MAGV)
)
go

/*==============================================================*/
/* Table: GIAOVIEN_LOPHOC                                       */
/*==============================================================*/
create table GIAOVIEN_LOPHOC (
   GIA_MAGV             nchar(10)            not null,
   MAKHOAHOC            nchar(10)            not null,
   MALOPHOC             nchar(10)            not null,
   MAGV                 nchar(10)            null,
   MALH                 nchar(10)            null,
   constraint PK_GIAOVIEN_LOPHOC primary key (MAKHOAHOC, GIA_MAGV, MALOPHOC)
)
go

/*==============================================================*/
/* Index: GIAOVIEN_LOPHOC_FK                                    */
/*==============================================================*/




create nonclustered index GIAOVIEN_LOPHOC_FK on GIAOVIEN_LOPHOC (GIA_MAGV ASC)
go

/*==============================================================*/
/* Index: GIAOVIEN_LOPHOC2_FK                                   */
/*==============================================================*/




create nonclustered index GIAOVIEN_LOPHOC2_FK on GIAOVIEN_LOPHOC (MAKHOAHOC ASC,
  MALOPHOC ASC)
go

/*==============================================================*/
/* Table: HOCVIEN                                               */
/*==============================================================*/
create table HOCVIEN (
   MASOHV               nchar(10)            not null,
   HOTENHV              nvarchar(50)         null,
   NGAYSINHHV           datetime             null,
   DIACHIHV             nvarchar(50)         null,
   SDTHV                nchar(11)            null,
   GIOITINH             nvarchar(3)          null,
   MASOLH               nchar(10)            null,
   constraint PK_HOCVIEN primary key (MASOHV)
)
go

/*==============================================================*/
/* Table: HOCVIEN_LOPHOC                                        */
/*==============================================================*/
create table HOCVIEN_LOPHOC (
   MASOHV               nchar(10)            not null,
   MAKHOAHOC            nchar(10)            not null,
   MALOPHOC             nchar(10)            not null,
   MALH                 nchar(10)            null,
   MAHV                 nchar(10)            null,
   constraint PK_HOCVIEN_LOPHOC primary key (MAKHOAHOC, MASOHV, MALOPHOC)
)
go

/*==============================================================*/
/* Index: HOCVIEN_LOPHOC_FK                                     */
/*==============================================================*/




create nonclustered index HOCVIEN_LOPHOC_FK on HOCVIEN_LOPHOC (MASOHV ASC)
go

/*==============================================================*/
/* Index: HOCVIEN_LOPHOC2_FK                                    */
/*==============================================================*/




create nonclustered index HOCVIEN_LOPHOC2_FK on HOCVIEN_LOPHOC (MAKHOAHOC ASC,
  MALOPHOC ASC)
go

/*==============================================================*/
/* Table: KETQUA                                                */
/*==============================================================*/
create table KETQUA (
   MAHV                 nchar(10)            not null,
   MALH                 nchar(10)            not null,
   MASOHV               nchar(10)            not null,
   DIEM                 float                null,
   XEPLOAI              nvarchar(10)         null,
   KETQUA               nvarchar(5)          null,
   constraint PK_KETQUA primary key (MALH, MAHV)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_3_FK on KETQUA (MASOHV ASC)
go

/*==============================================================*/
/* Table: KHOAHOC                                               */
/*==============================================================*/
create table KHOAHOC (
   MAKHOAHOC            nchar(10)            not null,
   TENKHOAHOC           nvarchar(20)         null,
   constraint PK_KHOAHOC primary key (MAKHOAHOC)
)
go

/*==============================================================*/
/* Table: LICHHOC                                               */
/*==============================================================*/
create table LICHHOC (
   MAKHOAHOC            nchar(10)            not null,
   MALOPHOC             nchar(10)            not null,
   MASOLOP              nchar(10)            not null,
   NGAYHOC              nvarchar(20)         not null,
   GIOHOC               nvarchar(20)         null,
   constraint PK_LICHHOC primary key (MAKHOAHOC, MALOPHOC, MASOLOP, NGAYHOC)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_2_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_2_FK on LICHHOC (MAKHOAHOC ASC,
  MALOPHOC ASC)
go

/*==============================================================*/
/* Table: LOPHOC                                                */
/*==============================================================*/
create table LOPHOC (
   MAKHOAHOC            nchar(10)            not null,
   MALOPHOC             nchar(10)            not null,
   MAKHOA               nchar(10)            null,
   TENLOP               nvarchar(30)         null,
   PHONG                nchar(5)             null,
   NGAYBD               datetime             null,
   NGAYKT               datetime             null,
   constraint PK_LOPHOC primary key (MAKHOAHOC, MALOPHOC)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_1_FK on LOPHOC (MAKHOAHOC ASC)
go

alter table BIENLAI
   add constraint FK_BIENLAI_RELATIONS_HOCVIEN foreign key (MASOHV)
      references HOCVIEN (MASOHV)
go

alter table GIAOVIEN_LOPHOC
   add constraint FK_GIAOVIEN_GIAOVIEN__GIAOVIEN foreign key (GIA_MAGV)
      references GIAOVIEN (MAGV)
go

alter table GIAOVIEN_LOPHOC
   add constraint FK_GIAOVIEN_GIAOVIEN__LOPHOC foreign key (MAKHOAHOC, MALOPHOC)
      references LOPHOC (MAKHOAHOC, MALOPHOC)
go

alter table HOCVIEN_LOPHOC
   add constraint FK_HOCVIEN__HOCVIEN_L_HOCVIEN foreign key (MASOHV)
      references HOCVIEN (MASOHV)
go

alter table HOCVIEN_LOPHOC
   add constraint FK_HOCVIEN__HOCVIEN_L_LOPHOC foreign key (MAKHOAHOC, MALOPHOC)
      references LOPHOC (MAKHOAHOC, MALOPHOC)
go

alter table KETQUA
   add constraint FK_KETQUA_RELATIONS_HOCVIEN foreign key (MASOHV)
      references HOCVIEN (MASOHV)
go

alter table LICHHOC
   add constraint FK_LICHHOC_RELATIONS_LOPHOC foreign key (MAKHOAHOC, MALOPHOC)
      references LOPHOC (MAKHOAHOC, MALOPHOC)
go

alter table LOPHOC
   add constraint FK_LOPHOC_RELATIONS_KHOAHOC foreign key (MAKHOAHOC)
      references KHOAHOC (MAKHOAHOC)
go

