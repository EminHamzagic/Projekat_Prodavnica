CREATE DATABASE Prodavnica

USE [Prodavnica]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTIKAL](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[naziv_artikla] [varchar](50) NULL,
	[sifra_artikla] [varchar](50) NULL,
	[jedinica_mere] [varchar](50) NULL,
	[stopa_poreska] [varchar](50) NULL,
	[vrsta_artikla] [varchar](50) NULL,
	[barkod] [varchar](50) NULL,
 CONSTRAINT [pk_artikal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALJI_DOKUMENTA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[id_zaglavlja] [int] NOT NULL,
	[id_artikla] [int] NOT NULL,
	[ulaz] [varchar](50) NULL,
	[izlaz] [varchar](50) NULL,
	[nab_cena] [varchar](50) NULL,
	[nab_vred] [varchar](50) NULL,
	[marza] [varchar](50) NULL,
	[prod_cena] [varchar](50) NULL,
	[prod_cena_pdv] [varchar](50) NULL,
	[prod_vred_pdv] [varchar](50) NULL,
	[vred_pdv] [varchar](50) NULL,
	[marza_vred] [varchar](50) NULL,
	[prod_cena_izlaz] [varchar](50) NULL,
	[prod_vred_izlaz] [varchar](50) NULL,
	[rabat_stopa] [varchar](50) NULL,
	[prod_cena_sa_rabatom] [varchar](50) NULL,
	[prod_cena_sa_rabatom_sa_PDV] [varchar](50) NULL,
	[prod_vred_sa_rabatom] [varchar](50) NULL,
	[prod_vred_sa_rabatom_sa_PDV] [varchar](50) NULL,
	[vred_pdv_sa_rabatom] [varchar](50) NULL,
	[vred_marze_sa_rabatom] [varchar](50) NULL,
	[pdv_stopa] [varchar](50) NULL,
	[nab_cena_pdv] [varchar](50) NULL,
	[trosak] [varchar](50) NULL,
	[opis_troska] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBRACUN_ZARADA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_radnika] [int] NOT NULL,
	[id_vrsta_zarade] [int] NOT NULL,
	[period_od] [date] NULL,
	[period_do] [date] NULL,
	[ukupna_zarada] [varchar](50) NOT NULL,
	[napomena] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POSLOVNI_PARTNERI](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[naziv_pp] [varchar](50) NULL,
	[PIB] [varchar](50) NULL,
	[maticni_broj] [varchar](50) NULL,
	[adresa] [varchar](50) NULL,
	[vrsta_pp] [varchar](50) NULL,
	[detalji_pp] [varchar](50) NULL,
 CONSTRAINT [pk_pp] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROFILI](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[lozinka] [varchar](50) NOT NULL,
	[tip_profila] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Radnik](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ime_prezime] [varchar](50) NULL,
	[JMBG] [varchar](50) NULL,
	[vrsta_radnika] [varchar](50) NULL,
	[korisnicko_ime] [varchar](50) NULL,
	[lozinka] [varchar](50) NULL,
	[adresa] [varchar](50) NULL,
	[mesecna_zarada] [varchar](50) NULL,
 CONSTRAINT [pk_radnik] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VRSTA_ZARADE](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[vrsta_zarade] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZAGLAVLJE_DOKUMENTA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[broj_dokumenta] [varchar](50) NULL,
	[nacin_placanja] [varchar](50) NULL,
	[id_poslovnog_partnera] [int] NOT NULL,
	[datum_dokumenta] [date] NULL,
	[napomena] [varchar](50) NULL,
	[vrsta_dokumenta] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZARADA_RADNIKA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_radnika] [int] NOT NULL,
	[period_od] [date] NULL,
	[period_do] [date] NULL,
	[iznos_zarade] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ARTIKAL] ON 

INSERT [dbo].[ARTIKAL] ([id], [naziv_artikla], [sifra_artikla], [jedinica_mere], [stopa_poreska], [vrsta_artikla], [barkod]) VALUES (1, N'wewew', N'4343', N'M', N'20', N'Trgovinska roba', N'3232377')
SET IDENTITY_INSERT [dbo].[ARTIKAL] OFF
GO
SET IDENTITY_INSERT [dbo].[DETALJI_DOKUMENTA] ON 

INSERT [dbo].[DETALJI_DOKUMENTA] ([ID], [id_zaglavlja], [id_artikla], [ulaz], [izlaz], [nab_cena], [nab_vred], [marza], [prod_cena], [prod_cena_pdv], [prod_vred_pdv], [vred_pdv], [marza_vred], [prod_cena_izlaz], [prod_vred_izlaz], [rabat_stopa], [prod_cena_sa_rabatom], [prod_cena_sa_rabatom_sa_PDV], [prod_vred_sa_rabatom], [prod_vred_sa_rabatom_sa_PDV], [vred_pdv_sa_rabatom], [vred_marze_sa_rabatom], [pdv_stopa], [nab_cena_pdv], [trosak], [opis_troska]) VALUES (1, 3, 1, N'9', N'0', N'9', N'9', N'9', N'9', N'9', N'9', N'9', N'9', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'9', N'9', N'9000', N'Dobar trosak?')
INSERT [dbo].[DETALJI_DOKUMENTA] ([ID], [id_zaglavlja], [id_artikla], [ulaz], [izlaz], [nab_cena], [nab_vred], [marza], [prod_cena], [prod_cena_pdv], [prod_vred_pdv], [vred_pdv], [marza_vred], [prod_cena_izlaz], [prod_vred_izlaz], [rabat_stopa], [prod_cena_sa_rabatom], [prod_cena_sa_rabatom_sa_PDV], [prod_vred_sa_rabatom], [prod_vred_sa_rabatom_sa_PDV], [vred_pdv_sa_rabatom], [vred_marze_sa_rabatom], [pdv_stopa], [nab_cena_pdv], [trosak], [opis_troska]) VALUES (4, 1, 1, NULL, N'9', N'50', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'9', N'81', N'0', N'9', N'10.8', N'81', N'97.2', N'16.2', N'72', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DETALJI_DOKUMENTA] OFF
GO
SET IDENTITY_INSERT [dbo].[OBRACUN_ZARADA] ON 

INSERT [dbo].[OBRACUN_ZARADA] ([id], [id_radnika], [id_vrsta_zarade], [period_od], [period_do], [ukupna_zarada], [napomena]) VALUES (2, 1, 1, CAST(N'2022-04-11' AS Date), CAST(N'2022-03-20' AS Date), N'10', N'Hi')
SET IDENTITY_INSERT [dbo].[OBRACUN_ZARADA] OFF
GO
SET IDENTITY_INSERT [dbo].[POSLOVNI_PARTNERI] ON 

INSERT [dbo].[POSLOVNI_PARTNERI] ([id], [naziv_pp], [PIB], [maticni_broj], [adresa], [vrsta_pp], [detalji_pp]) VALUES (1, N'Jas', N'12345', N'8888', N'Stevana NEmanje', N'--Selektuj vrstu PP--', N'dobar decko')
SET IDENTITY_INSERT [dbo].[POSLOVNI_PARTNERI] OFF
GO
SET IDENTITY_INSERT [dbo].[PROFILI] ON 

INSERT [dbo].[PROFILI] ([id], [username], [lozinka], [tip_profila]) VALUES (2, N'Synapso', N'admin', N'admin')
INSERT [dbo].[PROFILI] ([id], [username], [lozinka], [tip_profila]) VALUES (4, N'Emin', N'pitica123', N'kasir')
SET IDENTITY_INSERT [dbo].[PROFILI] OFF
GO
SET IDENTITY_INSERT [dbo].[Radnik] ON 

INSERT [dbo].[Radnik] ([id], [ime_prezime], [JMBG], [vrsta_radnika], [korisnicko_ime], [lozinka], [adresa], [mesecna_zarada]) VALUES (1, N'Emin Hamzagic', N'989898989', N'Administrator', N'Synapso', N'admin', N'8. Mart', N'60000')
INSERT [dbo].[Radnik] ([id], [ime_prezime], [JMBG], [vrsta_radnika], [korisnicko_ime], [lozinka], [adresa], [mesecna_zarada]) VALUES (3, N'Medžid Jašarovic', N'03128992323', N'Kasir', N'Jasarovic03', N'pitasakrompirom15', N'Hotkovo', N'40000')
SET IDENTITY_INSERT [dbo].[Radnik] OFF
GO
SET IDENTITY_INSERT [dbo].[VRSTA_ZARADE] ON 

INSERT [dbo].[VRSTA_ZARADE] ([id], [vrsta_zarade]) VALUES (1, N'DObra zarada')
INSERT [dbo].[VRSTA_ZARADE] ([id], [vrsta_zarade]) VALUES (2, N'Losa zarada')
SET IDENTITY_INSERT [dbo].[VRSTA_ZARADE] OFF
GO
SET IDENTITY_INSERT [dbo].[ZAGLAVLJE_DOKUMENTA] ON 

INSERT [dbo].[ZAGLAVLJE_DOKUMENTA] ([ID], [broj_dokumenta], [nacin_placanja], [id_poslovnog_partnera], [datum_dokumenta], [napomena], [vrsta_dokumenta]) VALUES (1, N'54511', N'VIRMAN', 1, CAST(N'2022-02-15' AS Date), N'dobar decko', N'Ulaz-Kalkulacija')
INSERT [dbo].[ZAGLAVLJE_DOKUMENTA] ([ID], [broj_dokumenta], [nacin_placanja], [id_poslovnog_partnera], [datum_dokumenta], [napomena], [vrsta_dokumenta]) VALUES (2, N'11', N'PLATNA KARTICA', 1, CAST(N'2022-04-12' AS Date), N'dobar decko', N'Ulaz-Kalkulacija')
INSERT [dbo].[ZAGLAVLJE_DOKUMENTA] ([ID], [broj_dokumenta], [nacin_placanja], [id_poslovnog_partnera], [datum_dokumenta], [napomena], [vrsta_dokumenta]) VALUES (3, N'3232', N'PLATNA KARTICA', 1, CAST(N'2022-03-24' AS Date), N'dsdssss', N'Izlaz-Racun')
SET IDENTITY_INSERT [dbo].[ZAGLAVLJE_DOKUMENTA] OFF
GO
SET IDENTITY_INSERT [dbo].[ZARADA_RADNIKA] ON 

INSERT [dbo].[ZARADA_RADNIKA] ([id], [id_radnika], [period_od], [period_do], [iznos_zarade]) VALUES (1, 1, CAST(N'2022-01-10' AS Date), CAST(N'2022-04-04' AS Date), N'777773333')
SET IDENTITY_INSERT [dbo].[ZARADA_RADNIKA] OFF
GO
ALTER TABLE [dbo].[DETALJI_DOKUMENTA]  WITH CHECK ADD  CONSTRAINT [fk_artikli_dokumenti] FOREIGN KEY([id_artikla])
REFERENCES [dbo].[ARTIKAL] ([id])
GO
ALTER TABLE [dbo].[DETALJI_DOKUMENTA] CHECK CONSTRAINT [fk_artikli_dokumenti]
GO
ALTER TABLE [dbo].[DETALJI_DOKUMENTA]  WITH CHECK ADD  CONSTRAINT [fk_zg] FOREIGN KEY([id_zaglavlja])
REFERENCES [dbo].[ZAGLAVLJE_DOKUMENTA] ([ID])
GO
ALTER TABLE [dbo].[DETALJI_DOKUMENTA] CHECK CONSTRAINT [fk_zg]
GO
ALTER TABLE [dbo].[OBRACUN_ZARADA]  WITH CHECK ADD FOREIGN KEY([id_radnika])
REFERENCES [dbo].[Radnik] ([id])
GO
ALTER TABLE [dbo].[OBRACUN_ZARADA]  WITH CHECK ADD FOREIGN KEY([id_radnika])
REFERENCES [dbo].[Radnik] ([id])
GO
ALTER TABLE [dbo].[OBRACUN_ZARADA]  WITH CHECK ADD FOREIGN KEY([id_vrsta_zarade])
REFERENCES [dbo].[VRSTA_ZARADE] ([id])
GO
ALTER TABLE [dbo].[OBRACUN_ZARADA]  WITH CHECK ADD FOREIGN KEY([id_vrsta_zarade])
REFERENCES [dbo].[VRSTA_ZARADE] ([id])
GO
ALTER TABLE [dbo].[ZAGLAVLJE_DOKUMENTA]  WITH CHECK ADD  CONSTRAINT [fk_zg_pp] FOREIGN KEY([id_poslovnog_partnera])
REFERENCES [dbo].[POSLOVNI_PARTNERI] ([id])
GO
ALTER TABLE [dbo].[ZAGLAVLJE_DOKUMENTA] CHECK CONSTRAINT [fk_zg_pp]
GO
ALTER TABLE [dbo].[ZARADA_RADNIKA]  WITH CHECK ADD  CONSTRAINT [fk_zr1] FOREIGN KEY([id_radnika])
REFERENCES [dbo].[Radnik] ([id])
GO
ALTER TABLE [dbo].[ZARADA_RADNIKA] CHECK CONSTRAINT [fk_zr1]
GO
