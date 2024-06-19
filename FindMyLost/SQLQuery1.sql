CREATE TABLE [dbo].[Lost_Item] (
    [item_id]            INT            IDENTITY (0, 1) NOT NULL,
    [item_category]      VARCHAR (50)   NOT NULL,
    [item_colour]        VARCHAR (50)   NOT NULL,
    [item_picture]       IMAGE          NULL,
    [last_seen_location] NVARCHAR (50)  NULL,
    [item_brand]         NVARCHAR (50)  NULL,
    [additional_info]    NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([item_id] ASC)
);

CREATE TABLE [dbo].[Found] (
    [found_id]             INT            IDENTITY (1, 1) NOT NULL,
    [claimer_name]         NVARCHAR (50)  NOT NULL,
    [claimer_address]      NVARCHAR (MAX) NOT NULL,
    [claimer_phone_number] NCHAR (10)     NOT NULL,
    [item_category]        NVARCHAR (50)  NOT NULL,
    [item_colour]          VARCHAR (50)   NOT NULL,
    [item_picture]         IMAGE          NULL,
    [last_seen_location]   NVARCHAR (50)  NULL,
    [item_brand]           NVARCHAR (50)  NULL,
    [additional_info]      NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([found_id] ASC)
);

CREATE TABLE [dbo].[Employee] (
    [employee_id]      INT            IDENTITY (100000, 1) NOT NULL,
    [first_name]       NVARCHAR (50)  NOT NULL,
    [last_name]        NVARCHAR (50)  NOT NULL,
    [email]            VARCHAR (320)  NOT NULL,
    [address]          NVARCHAR (MAX) NOT NULL,
    [mobile_number]    NCHAR (10)     NOT NULL,
    [telephone_number] NCHAR (10)     NOT NULL,
    [password]         NVARCHAR (50)  NOT NULL,
    [picture]          IMAGE          NULL,
    [position]         NVARCHAR (50)  NOT NULL,
    [gender]           NVARCHAR (50)  NULL,
    [DOB]              DATE           NULL,
    PRIMARY KEY CLUSTERED ([employee_id] ASC)
);

CREATE TABLE [dbo].[Claim] (
    [claim_id]             INT            IDENTITY (0, 1) NOT NULL,
    [claimer_name]         NVARCHAR (50)  NOT NULL,
    [claimer_address]      NVARCHAR (MAX) NOT NULL,
    [claimer_phone_number] NCHAR (10)     NOT NULL,
    [item_category]        NVARCHAR (50)  NOT NULL,
    [item_colour]          VARCHAR (50)   NOT NULL,
    [item_picture]         IMAGE          NULL,
    [last_seen_location]   NVARCHAR (50)  NULL,
    [item_brand]           NVARCHAR (50)  NULL,
    [additional_info]      NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([claim_id] ASC)
);

INSERT INTO Employee (first_name, last_name, email, address, mobile_number, telephone_number, password, picture, position, gender, DOB) VALUES ('first_name', 'last_name', 'email', 'address', 'mobile', 'telephone', 'password', '/Images/user-avatar.jpg', 'position', 'gender', '09-Jan-68');