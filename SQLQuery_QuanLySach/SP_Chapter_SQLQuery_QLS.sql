USE QuanLySach;
GO
-- sp cho Chapter
CREATE proc spLayToanBoChapter
AS
BEGIN
	SELECT *
	FROM Chapter
END;

CREATE proc spLayToanBoChapterDuaTheoBookID (@bookID nvarchar(15))
AS
BEGIN
	SELECT *
	FROM Chapter
	WHERE @bookID = bookID
END;
GO
-- them
CREATE proc spThemMotChapter (
	@chapterNumber smallint,
	@bookID nvarchar(15),
	@chapterTitle nvarchar(250),
	@objective nvarchar(MAX),
	@partNumber smallint,
	@content nvarchar(MAX)
	)
AS
BEGIN
	INSERT INTO Chapter
	VALUES(@chapterNumber, @bookID, @chapterTitle, @objective, @partNumber, @content)
END;

-- sua
CREATE proc spSuaMotChapter (
	@chapterNumber smallint,
	@bookID nvarchar(15),
	@chapterTitle nvarchar(250),
	@objective nvarchar(MAX),
	@partNumber smallint,
	@content nvarchar(MAX) )
AS
BEGIN
	UPDATE Chapter
	SET
	chapterTitle = @chapterTitle,
	objective = @objective,
	partNumber = @partNumber,
	content = @content
	WHERE chapterNumber = @chapterNumber AND bookID = @bookID
END;

-- xoa
CREATE proc spXoaMotChapter ( @chapterNumber smallint )
AS
BEGIN
	DELETE FROM Chapter
	WHERE chapterNumber = @chapterNumber
END;


CREATE proc spXoaToanBoChapter ( @chapterNumber smallint )
AS
BEGIN
	DELETE Chapter
END;

EXEC spThemMotChapter  1, 'b01', N'Giới thiệu', N'Hiểu được lập trình', 1 , N'Nội dung chương'
EXEC spThemMotChapter  2, 'b01', N'Unit 1', N'Hiểu được lập trình', 2 , N'Nội dung chương'

EXEC spThemMotChapter  1, 'b03', N'Ban phien am quoc te', N'Hiểu được bang phien am quoc te', 1 , N'Nội dung chương'
EXEC spThemMotChapter  2, 'b03', N'Tu vung can ban', N'Biet nhieu tu vung', 2 , N'Nội dung chương'