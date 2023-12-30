CREATE TABLE [dbo].[Seller_Reg] (
    [Seller_id]       INT            IDENTITY (1, 1) NOT NULL,
    [Seller_name]     NVARCHAR (MAX) NOT NULL,
    [Seller_address]  NVARCHAR (MAX) NOT NULL,
    [Seller_pass]     NCHAR (20)     NOT NULL,
    [Seller_phone_no] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Seller_id] ASC)
);
CREATE TABLE [dbo].[Product] (
    [Product_id]   INT            IDENTITY (1, 1) NOT NULL,
    [Product_name] NVARCHAR (MAX) NOT NULL,
    [Product_type] NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Product_id] ASC)
);
CREATE TABLE [dbo].[Cart] (
    [Cart_id]    INT          IDENTITY (1, 1) NOT NULL,
    [Product_id] INT          NOT NULL,
    [Quantity]   NCHAR (10)   NOT NULL,
    [Total_cost] NUMERIC (18) NOT NULL,
    PRIMARY KEY CLUSTERED ([Cart_id] ASC)
);
CREATE TABLE [dbo].[Customer_Reg] (
    [Customer_id]      INT            IDENTITY (1, 1) NOT NULL,
    [Customer_name]    NVARCHAR (MAX) NOT NULL,
    [Customer_pass]    NCHAR (10)     NOT NULL,
    [Customer_address] NVARCHAR (MAX) NOT NULL,
    [Customer_phn_no]  INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Customer_id] ASC)
);

