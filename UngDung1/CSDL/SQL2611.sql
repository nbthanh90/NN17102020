USE [Test]
GO
/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 11/26/2020 8:58:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSinhVien](
	[MaSV] [nchar](10) NOT NULL,
	[TenSV] [nchar](100) NULL,
	[DiaChi] [ntext] NULL,
	[SDT] [nchar](15) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTInh] [bit] NULL,
 CONSTRAINT [PK_tblSinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
