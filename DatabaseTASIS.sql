USE [Tasis]
GO
/****** Object:  User [sdf]    Script Date: 07/11/2021 20:12:24 ******/
CREATE USER [sdf] FOR LOGIN [sdf] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Siswa]    Script Date: 07/11/2021 20:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siswa](
	[ID] [bigint] IDENTITY(10000,3) NOT NULL,
	[Nama] [varchar](30) NOT NULL,
	[Kelas] [varchar](20) NOT NULL,
	[Alamat] [varchar](300) NOT NULL,
	[Saldo] [bigint] NULL,
 CONSTRAINT [PK_Siswa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaksi]    Script Date: 07/11/2021 20:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaksi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[No_Rekening] [bigint] NULL,
	[Tanggal] [datetime] NOT NULL,
	[Setoran] [bigint] NOT NULL,
	[Penarikan] [bigint] NOT NULL,
	[Saldo]  AS ([Setoran]-[Penarikan]),
 CONSTRAINT [PK_Transaksi_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Siswa] ADD  CONSTRAINT [DF_Siswa_Saldo]  DEFAULT ((0)) FOR [Saldo]
GO
ALTER TABLE [dbo].[Transaksi] ADD  CONSTRAINT [DF_Transaksi_No_Rekening]  DEFAULT ((0)) FOR [No_Rekening]
GO
ALTER TABLE [dbo].[Transaksi] ADD  CONSTRAINT [DF_Transaksi_Setoran]  DEFAULT ((0)) FOR [Setoran]
GO
ALTER TABLE [dbo].[Transaksi] ADD  CONSTRAINT [DF_Transaksi_Penarikan]  DEFAULT ((0)) FOR [Penarikan]
GO
ALTER TABLE [dbo].[Transaksi]  WITH CHECK ADD  CONSTRAINT [FK_Transaksi_Siswa] FOREIGN KEY([No_Rekening])
REFERENCES [dbo].[Siswa] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Transaksi] CHECK CONSTRAINT [FK_Transaksi_Siswa]
GO
