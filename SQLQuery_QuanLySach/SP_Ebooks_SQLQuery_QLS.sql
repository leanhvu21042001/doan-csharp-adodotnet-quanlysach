USE QuanLySach;
GO
-- sp cho Ebooks // FALSE
drop proc spLayToanBoEbooks
AS
BEGIN
	SELECT eb.*, ct.chapterNumber, ct.chapterTitle, ct.objective, ct.partNumber, ct.[content]
	FROM Ebooks eb JOIN Chapter ct on eb.bookID = ct.bookID
END;
GO

-- sp cho Ebooks// TRUE
CREATE proc spLayToanBoEbooks
AS
BEGIN
	SELECT *
	FROM Ebooks
END;
-- them
CREATE proc spThemMotEbooks (
	@bookID nvarchar(15),
	@bookTitle nvarchar(250),
	@introduction nvarchar(MAX),
	@authorName nvarchar(150),
	@publisherName nvarchar(150) )
AS
BEGIN
	INSERT INTO Ebooks
	VALUES(@bookID, @bookTitle,@introduction, @authorName, @publisherName)
END;

-- sua
CREATE proc spSuaMotEbooks (
	@bookID nvarchar(15),
	@bookTitle nvarchar(250),
	@introduction nvarchar(MAX),
	@authorName nvarchar(150),
	@publisherName nvarchar(150) )
AS
BEGIN
	UPDATE Ebooks
	SET
	bookTitle = @bookTitle,
	introduction = @introduction,
	authorName = @authorName,
	publisherName = @publisherName
	WHERE bookID = @bookID
END;

-- xoa
CREATE proc spXoaMotEbooks ( @bookID nvarchar(15) )
AS
BEGIN
	DELETE FROM Ebooks
	WHERE bookID = @bookID
END;
CREATE proc spXoaToanBoEbooks 
AS
BEGIN
	DELETE Ebooks
END;
EXEC spThemMotEbooks 'b01', N'Lập trình C# căn bản', N'Sách dạy lập trình căn bản môn C#', N'Nguyễn văn tèo', N'Nhà xuất bản Đồng Nai'
EXEC spThemMotEbooks 'b02', N'Lập trình C++ căn bản và nâng cao', N'Lập trình C++ từ căn bản đến nâng cao ', N'Thân Anh còi', N'Nhà xuất bản Đồng Trẻ'
EXEC spThemMotEbooks 'b03', N'Học Tiếng Anh cho tốt', N'Học Tiêng Anh cho tốt', N'Trần tấn Hưng', N'Nhà xuất bản Âm nhạc'

EXEC spLayToanBoEbooks

