CREATE TABLE ShippingDetails (
	[ShippingDetailsId] INT Identity NOT NULL,
	[Name] NVARCHAR(MAX) NULL,
	[Email] NVARCHAR(MAX) NULL,
	[Country] NVARCHAR(MAX) NULL,
	CONSTRAINT [PK_dbo.ShippingDetails] PRIMARY KEY CLUSTERED ([ShippingDetailsId] ASC)
	);