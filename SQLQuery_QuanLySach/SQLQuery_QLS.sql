CREATE DATABASE QuanLySach;
GO
USE QuanLySach;
GO

-- TAO TABLE

CREATE TABLE Ebooks (
	bookID nvarchar(15) primary key not null,
	bookTitle nvarchar(250) not null,
	introduction nvarchar(MAX) not null, -- gioi thieu
	authorName nvarchar(150) not null,
	publisherName nvarchar(150) not null
);

GO

CREATE TABLE Chapter (
	chapterNumber smallint not null,
	bookID nvarchar(15) not null foreign key(bookID) references Ebooks(bookID),
	chapterTitle nvarchar(250) not null,
	objective nvarchar(MAX) not null,
	partNumber smallint not null, --# phan can ban hoac nang cao
	[content] nvarchar(MAX) not null,
	primary key(chapterNumber, bookID)
);

GO
