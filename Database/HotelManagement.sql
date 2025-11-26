CREATE DATABASE HotelManagement;
GO
USE HotelManagement;
GO
SET DATEFORMAT DMY;
GO
-- Bảng Tài khoản (Account)
CREATE TABLE Account (
    AccountID char(10) PRIMARY KEY,                          -- Mã tài khoản (tự tăng)
    Username NVARCHAR(50) NOT NULL,                                   -- Tên đăng nhập
    Password NVARCHAR(50) NOT NULL,                                   -- Mật khẩu (hash)
    StartDate DATE NOT NULL DEFAULT GETDATE(),                        -- Ngày bắt đầu tạo
    StaffID Char(10),                                                 -- Liên kết nhân viên
    Status NVARCHAR(20) NOT NULL 
        DEFAULT N'Active' CHECK (Status IN (N'Active', N'Inactive')), -- Trạng thái
    CONSTRAINT UQ_Account_Username UNIQUE (Username)                  -- Không trùng username
);
GO

-- Bảng Nhân viên (Staff)
CREATE TABLE Staff (
    StaffID Char(10) PRIMARY KEY,                        -- Mã nhân viên (tự tăng)
    FullName NVARCHAR(255) NOT NULL,                     -- Họ và tên
    Role NVARCHAR(50),                                   -- Vai trò (Receptionist, Manager…)
    DateOfBirth DATE,                                    -- Ngày sinh
    Gender NVARCHAR(10) CHECK (Gender IN (N'Male', N'Female')), -- Giới tính
    PhoneNumber VARCHAR(15) UNIQUE,                      -- Số điện thoại (duy nhất)
    CitizenID VARCHAR(12) UNIQUE,                        -- Căn cước công dân (CCCD/CMND)
    StartDate DATE NOT NULL DEFAULT GETDATE(),           -- Ngày bắt đầu làm việc
    Notes NVARCHAR(MAX)                                  -- Ghi chú thêm
);
GO

-- Bảng Khách hàng (Customer)
CREATE TABLE Customer (
    CustomerID char(10) PRIMARY KEY ,        -- Mã khách hàng (tự tăng)
    FullName NVARCHAR(100) NOT NULL,                 -- Họ tên
    PhoneNumber VARCHAR(15) NOT NULL UNIQUE,         -- Số điện thoại
    NationalID VARCHAR(20) NOT NULL UNIQUE,          -- Căn cước công dân (CCCD)
    Address NVARCHAR(200),                           -- Địa chỉ (số nhà, đường, ...)
    Country NVARCHAR(100),                           -- Quốc gia
    Gender NVARCHAR(10),                             -- Giới tính
    DateOfBirth DATE,                                -- Ngày sinh
    RankID int not null
);
GO

-- Bảng Loại khách hàng (Rank/Level)
CREATE TABLE CustomerRank (
    RankID INT PRIMARY KEY IDENTITY(1,1),       -- Mã rank (0,1,2,3,4,5)
    RankName NVARCHAR(50) NOT NULL UNIQUE,       -- Tên hạng (Thường, Silver, Gold...) - duy nhất
    DiscountPercent DECIMAL(5,2) NOT NULL,      -- % giảm giá
    MinSpending DECIMAL(18,2) DEFAULT 0         -- Điều kiện tổng chi tiêu tối thiểu
);
GO

--Bảng RoomType (loại phòng)
CREATE TABLE RoomType (
    RoomTypeID char(10)PRIMARY KEY,   -- Mã loại phòng
    TypeName NVARCHAR(50) NOT NULL,             -- Tên loại (Single, Double, VIP...)
    PricePerDay DECIMAL(18,2) NOT NULL,         -- Giá thuê theo ngày
    PricePerHour DECIMAL(18,2) NOT NULL,        -- Giá thuê theo giờ
    Category NVARCHAR(20) NOT NULL DEFAULT N'Standard',
    Description NVARCHAR(MAX)                   -- Mô tả thêm
);
GO

-- Bảng giá phòng động theo thời gian
CREATE TABLE RoomTypePrice (
    PriceID INT IDENTITY(1,1) PRIMARY KEY,
    RoomTypeID char(10) not null,                     -- Loại phòng áp dụng
    StartDate DATE NOT NULL,                     -- Ngày bắt đầu áp dụng
    EndDate DATE NOT NULL,                       -- Ngày kết thúc áp dụng
    PricePerDay DECIMAL(18,2) NOT NULL,          -- Giá thuê theo ngày trong giai đoạn này
    PricePerHour DECIMAL(18,2) NOT NULL,         -- Giá thuê theo giờ trong giai đoạn này
    Note NVARCHAR(max),                          -- Ghi chú (VD: Lễ 30/4-1/5, Giảm giá mùa thấp điểm...)
   
);

-- Bảng Room (Phòng)
CREATE TABLE Room (
    RoomID char(10) PRIMARY KEY,      -- Mã phòng (tự tăng)
    RoomName NVARCHAR(50) NOT NULL,            -- Tên phòng
    RoomTypeID char(10) NOT NULL,                   -- FK đến loại phòng
    Capacity INT NOT NULL DEFAULT 1,           -- Sức chứa tối đa
    Description NVARCHAR(MAX),                 -- Mô tả thêm
    Status NVARCHAR(20) NOT NULL               -- Trạng thái phòng
        CONSTRAINT DF_Room_Status DEFAULT N'Available',
	Official Nvarchar(50),
	 RepairNote NVARCHAR(MAX) NULL
);
GO

--Bảng đánh giá phòng
CREATE TABLE RoomEvaluation (
    EvaluationID INT IDENTITY(1,1) PRIMARY KEY,
    RoomID char(10) NOT NULL,                             
    EvaluationDate DATE NOT NULL DEFAULT GETDATE(), 
    
    -- Nhóm cơ bản
    CleanlinessScore INT CHECK (CleanlinessScore BETWEEN 1 AND 10), -- Vệ sinh
    ComfortScore INT CHECK (ComfortScore BETWEEN 1 AND 10),         -- Tiện nghi (giường, phòng ốc)
    ServiceScore INT CHECK (ServiceScore BETWEEN 1 AND 10),         -- Thái độ phục vụ

    -- Nhóm tiện ích bổ sung
    FacilitiesScore INT CHECK (FacilitiesScore BETWEEN 1 AND 10),   -- Tiện ích trong phòng (TV, minibar, WiFi…)
    LocationScore INT CHECK (LocationScore BETWEEN 1 AND 10),       -- Vị trí (view, độ yên tĩnh)
    SafetyScore INT CHECK (SafetyScore BETWEEN 1 AND 10),           -- An toàn (PCCC, bảo mật)
    
    -- Nhóm cao cấp (quan trọng cho VIP)
    LuxuryScore INT CHECK (LuxuryScore BETWEEN 1 AND 10),           -- Độ sang trọng (nội thất, trang trí)
    TechnologyScore INT CHECK (TechnologyScore BETWEEN 1 AND 10),   -- Công nghệ (smart TV, smart key, điều khiển tự động…)
    StaffScore INT CHECK (StaffScore BETWEEN 1 AND 10),             -- Đội ngũ nhân viên hỗ trợ riêng

    Evaluator NVARCHAR(100)                                         -- Người đánh giá (quản lý/khách)
);
GO

-- Bảng kho thiết bị
CREATE TABLE EquipmentStorage (
    EquipmentID char(10) PRIMARY KEY,   -- Mã thiết bị trong kho
    EquipmentName NVARCHAR(100) NOT NULL,        -- Tên thiết bị
    EquipmentCategory NVARCHAR(50),              -- Nhóm thiết bị (Y tế, Nội thất, Điện tử...)
    Quantity INT NOT NULL DEFAULT 1,             -- Số lượng trong kho
    PurchaseDate DATE DEFAULT GETDATE(),         -- Ngày nhập kho
    Status NVARCHAR(50) DEFAULT N'Available',    -- Trạng thái (Available, In Use, Damaged, Maintenance...)
    Description NVARCHAR(MAX),                   -- Mô tả thêm
    StaffID char(10)
);
GO

-- Bảng nối giữa phòng và thiết bị
CREATE TABLE RoomEquipment (
    RoomEquipmentID char(10) PRIMARY KEY, -- Mã tự tăng
    RoomID char(10) NOT NULL,                           -- FK đến phòng
    EquipmentStorage Char(10) NOT NULL,                  -- FK đến loại thiết bị
    Quantity INT NOT NULL DEFAULT 1,               -- Số lượng thiết bị
    InstalledDate DATE DEFAULT GETDATE(),          -- Ngày lắp đặt
    Condition NVARCHAR(50) DEFAULT N'Good',        -- Tình trạng (Good, Damaged, Under Maintenance...)
    Note NVARCHAR(max),                             -- Ghi chú thêm
    StaffID char(10)
);
GO

-- Loại phí (dịch vụ, bồi thường, khác) + giá mặc định
CREATE TABLE FeeType (
    FeeTypeID Char(10) PRIMARY KEY,
    FeeTypeName NVARCHAR(100) NOT NULL,      -- Tên phí: 'Check-in sớm', 'Thêm giường', 'Hỏng máy lạnh'
    Category NVARCHAR(50) NOT NULL,          -- Nhóm: 'Phụ phí dịch vụ', 'Bồi thường hư hỏng'
    DefaultPrice DECIMAL(18,2) NOT NULL,     -- Giá mặc định cho loại phí này
    Notes NVARCHAR(max)                      -- Ghi chú (nếu cần)
);
GO

-- Các phí phát sinh thực tế của từng booking
CREATE TABLE BookingFee (
    BookingFeeID char(10) PRIMARY KEY,
    BookingID char(10) NOT NULL,                      -- Liên kết booking
    FeeTypeID char(10) NOT NULL,                      -- Liên kết loại phí
    Quantity INT NOT NULL DEFAULT 1,             -- Số lượng (VD: 2 khăn tắm bị mất)
    CreatedAt DATETIME DEFAULT GETDATE(),        -- Ngày ghi nhận phí
    Notes NVARCHAR(max),                         -- Ghi chú thêm
);
GO

-- Bảng Booking (Đặt phòng)
CREATE TABLE Booking(
    BookingID Char(10) PRIMARY KEY, -- Mã đặt phòng
    CustomerID char(10) NOT NULL,                 -- Mã khách hàng
    RoomID char(10) NOT NULL,                     -- Mã phòng
    RentalType NVARCHAR(10) NOT NULL         -- Kiểu thuê: 'Day' hoặc 'Hour'
        CONSTRAINT CK_Booking_RentalType CHECK (RentalType IN (N'Day', N'Hour')),
    CheckIn DATETIME NOT NULL,               -- Thời gian vào
    CheckOut DATETIME,                       -- Thời gian ra
    Price DECIMAL(18,2) NOT NULL,            -- Giá tại thời điểm đặt (theo ngày/giờ)
    Status NVARCHAR(20) NOT NULL             -- Trạng thái đặt phòng (CheckIn, CheckOut, Reserved...)
        CONSTRAINT DF_Booking_Status DEFAULT N'CheckIn',
    StaffID Char(10) NOT NULL,               -- Nhân viên chịu trách nhiệm booking
);
GO

-- Bảng Dịch vụ (Service)
CREATE TABLE Service (
    ServiceID char(10) PRIMARY KEY,    -- Mã dịch vụ
    ServiceName NVARCHAR(100) NOT NULL,         -- Tên dịch vụ (Ăn sáng, Giặt ủi…)
    Category NVARCHAR(50),                      -- Nhóm dịch vụ (Ăn uống, Giặt ủi, Vận chuyển…)
    Price DECIMAL(18,2) NOT NULL,               -- Giá dịch vụ
    Description NVARCHAR(200)                   -- Mô tả chi tiết
);
GO

-- Bảng Sử dụng dịch vụ (ServiceUsage)
CREATE TABLE ServiceUsage (
    UsageID char(10) PRIMARY KEY,     -- Mã sử dụng dịch vụ
    BookingID char(10) NOT NULL,                    -- Mã đặt phòng (liên kết Booking)
    ServiceID char(10) NOT NULL,                    -- Mã dịch vụ (liên kết Service)
    Quantity INT NOT NULL DEFAULT 1,           -- Số lượng
    StaffID Char(10) NOT NULL,                  -- Nhân viên phụ trách dịch vụ
	UsageDate DATETIME NOT NULL DEFAULT GETDATE()-- Ngày sử dụng dịch vụ
);
GO

-- Bảng Hóa đơn
CREATE TABLE Invoice (
    InvoiceID char(10) PRIMARY KEY, -- Mã hóa đơn
    BookingID char(10) NOT NULL,                  -- Mã đặt phòng (FK)
    InvoiceDate DATETIME NOT NULL DEFAULT GETDATE(), -- Ngày lập hóa đơn
    TotalAmount DECIMAL(18,2) NOT NULL,      -- Tổng tiền thanh toán
    PaymentMethod NVARCHAR(50) NOT NULL,     -- Hình thức thanh toán (Cash, Card, Transfer...)
    PaidStatus NVARCHAR(20) NOT NULL 
        CONSTRAINT DF_Invoice_PaidStatus DEFAULT N'Unpaid', -- Trạng thái thanh toán
    StaffID CHAR(10) NOT NULL,               -- Nhân viên lập hóa đơn
    Note NVARCHAR(200),                      -- Ghi chú thêm
	CreatedBy    NVARCHAR(20)  NOT NULL DEFAULT 'UNKNOWN',
    AuditStatus  NVARCHAR(20)  NOT NULL DEFAULT 'OK',
    AuditNote    NVARCHAR(255) NULL,
    AuditedBy    NVARCHAR(20)  NULL,
    AuditedAt    DATETIME      NULL
);

ALTER TABLE Booking 
ADD 
    -- Khóa ngoại liên kết đến bảng Customer (mỗi Booking phải thuộc 1 khách hàng)
    CONSTRAINT FK_Booking_Customer FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),

    -- Khóa ngoại liên kết đến bảng Room (mỗi Booking phải thuộc 1 phòng)
    CONSTRAINT FK_Booking_Room FOREIGN KEY (RoomID) REFERENCES Room(RoomID),

     -- Khóa ngoại liên kết đến bảng Nhân viên (mỗi Booking phải thuộc 1 nhân viên)
    CONSTRAINT FK_Booking_Staff FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)  ON DELETE CASCADE ON UPDATE CASCADE;
GO
-- Thêm khóa ngoại cho bảng ServiceUsage
ALTER TABLE ServiceUsage 
ADD 
    -- Khóa ngoại liên kết đến bảng Booking (mỗi lần dùng dịch vụ thuộc về 1 lần đặt phòng)
    CONSTRAINT FK_ServiceUsage_Booking FOREIGN KEY (BookingID) REFERENCES Booking(BookingID),

    -- Khóa ngoại liên kết đến bảng Service (mỗi lần dùng dịch vụ phải chọn 1 dịch vụ)
    CONSTRAINT FK_ServiceUsage_Service FOREIGN KEY (ServiceID) REFERENCES Service(ServiceID),
    
      -- Khóa ngoại liên kết đến bảng Nhân viên (mỗi ServiceUsage phải thuộc 1 nhân viên)
    CONSTRAINT FK_ServiceUsage_Staff FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)  ON DELETE CASCADE ON UPDATE CASCADE;
GO

-- Thêm khóa ngoại liên kết đến bảng Staff
ALTER TABLE Account
ADD CONSTRAINT FK_Account_Staff FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)  ON DELETE CASCADE ON UPDATE CASCADE;
GO
-- Bảng BookingFee tham chiếu đến Booking và FeeType
ALTER TABLE BookingFee
ADD
    CONSTRAINT FK_BookingFee_Booking FOREIGN KEY (BookingID) REFERENCES Booking(BookingID),  -- Liên kết phí phát sinh với một Booking cụ thể
    CONSTRAINT FK_BookingFee_FeeType FOREIGN KEY (FeeTypeID) REFERENCES FeeType(FeeTypeID)  ON DELETE CASCADE ON UPDATE CASCADE;  -- Loại phí (dịch vụ, phụ thu...)
GO

--Bảng khóa ngoại khách sạn
ALTER TABLE Customer
ADD CONSTRAINT FK_Customer_Rank FOREIGN KEY (RankID) REFERENCES CustomerRank(RankID)  ON DELETE CASCADE ON UPDATE CASCADE;
GO
-- Bảng Invoice tham chiếu đến Booking và Staff
ALTER TABLE Invoice
ADD
    CONSTRAINT FK_Invoice_Booking FOREIGN KEY (BookingID)  
        REFERENCES Booking(BookingID) ,   -- Nếu xóa hoặc cập nhật Booking thì hóa đơn cũng thay đổi tương ứng
    CONSTRAINT FK_Invoice_Staff FOREIGN KEY (StaffID)  
        REFERENCES Staff(StaffID)  ON DELETE CASCADE ON UPDATE CASCADE;             -- Nhân viên lập hóa đơn
GO
-- Bảng Room tham chiếu đến RoomType
ALTER TABLE Room
ADD
    CONSTRAINT FK_Room_RoomType FOREIGN KEY(RoomTypeID) REFERENCES RoomType(RoomTypeID)  ON DELETE CASCADE ON UPDATE CASCADE; -- Mỗi phòng thuộc một loại phòng
GO
ALTER TABLE RoomEquipment
ADD CONSTRAINT FK_RoomEquipment_EquipmentStorage
    FOREIGN KEY (EquipmentStorage) REFERENCES EquipmentStorage(EquipmentID)  ON DELETE CASCADE ON UPDATE CASCADE;
GO

ALTER TABLE RoomEquipment
ADD CONSTRAINT FK_RoomEquipment_Staff
    FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)  ON DELETE CASCADE ON UPDATE CASCADE;
GO 

ALTER TABLE RoomEquipment
ADD CONSTRAINT FK_RoomEquipment_Room
    FOREIGN KEY (RoomID) REFERENCES Room(RoomID)  ON DELETE CASCADE ON UPDATE CASCADE;
GO

ALTER TABLE EquipmentStorage
ADD CONSTRAINT FK_EquipmentStorage_Staff
    FOREIGN KEY (StaffID) REFERENCES Staff(StaffID);
GO
ALter table RoomTypePrice
ADD CONSTRAINT FK_RoomTypePrice_RoomType
FOREIGN KEY (RoomTypeID) REFERENCES RoomType(RoomTypeID)  ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE RoomEvaluation
ADD CONSTRAINT FK_RoomEvaluation_Room
FOREIGN KEY (RoomID) REFERENCES Room(RoomID) ON DELETE CASCADE ON UPDATE CASCADE;
GO
CREATE TABLE MaintenanceType (
    MaintenanceTypeID INT IDENTITY(1,1) PRIMARY KEY,
    TypeName NVARCHAR(100) NOT NULL UNIQUE,   -- VD: Bảo trì phòng, Bảo trì thiết bị
    Description NVARCHAR(MAX)
);
go
CREATE TABLE MaintenanceLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    MaintenanceTypeID INT NOT NULL,
    RoomID CHAR(10) NULL,             
    RoomEquipmentID CHAR(10) NULL,     -- mã thiết bị cụ thể trong phòng (REQxxx)

    StaffID CHAR(10) NOT NULL,

    MaintenanceDate DATETIME NOT NULL DEFAULT GETDATE(),
    Status NVARCHAR(50) NOT NULL DEFAULT N'Not completed',
    Note NVARCHAR(MAX),
    CONSTRAINT CK_MaintenanceLog_Target CHECK (
        (RoomID IS NOT NULL AND RoomEquipmentID IS NULL) OR
        (RoomID IS NULL AND RoomEquipmentID IS NOT NULL)
    ),

    CONSTRAINT FK_MaintenanceLog_Type
        FOREIGN KEY (MaintenanceTypeID) REFERENCES MaintenanceType(MaintenanceTypeID),

    CONSTRAINT FK_MaintenanceLog_Room
        FOREIGN KEY (RoomID) REFERENCES Room(RoomID),

    CONSTRAINT FK_MaintenanceLog_RoomEquip
        FOREIGN KEY (RoomEquipmentID) REFERENCES RoomEquipment(RoomEquipmentID),

    CONSTRAINT FK_MaintenanceLog_Staff
        FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);
go
CREATE OR ALTER PROCEDURE sp_GetInvoiceDetailByBooking
    @BookingID CHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE 
        @CustomerID CHAR(10),
        @RankID CHAR(10),
        @DiscountPercent DECIMAL(5,2) = 0,
        @TotalBefore DECIMAL(18,2) = 0,
        @TotalAfter DECIMAL(18,2) = 0;

    -- Lấy khách
    SELECT @CustomerID = CustomerID 
    FROM Booking 
    WHERE BookingID = @BookingID;

    -- Lấy Rank
    SELECT @RankID = RankID 
    FROM Customer 
    WHERE CustomerID = @CustomerID;

    -- Lấy % giảm
    SELECT @DiscountPercent = ISNULL(DiscountPercent, 0)
    FROM CustomerRank 
    WHERE RankID = @RankID;

    -- Tính tổng tiền
    SELECT @TotalBefore =
        (
            (CASE WHEN b.RentalType = 'Day' THEN ISNULL(p.PricePerDay, rt.PricePerDay)
                  ELSE ISNULL(p.PricePerHour, rt.PricePerHour) END)
            *
            (CASE WHEN b.RentalType = 'Day' THEN CEILING(DATEDIFF(HOUR, b.CheckIn, ISNULL(b.CheckOut, GETDATE())) / 24.0)
                  ELSE CEILING(DATEDIFF(HOUR, b.CheckIn, ISNULL(b.CheckOut, GETDATE()))) END)
            +
            ISNULL((SELECT SUM(s.Price * su.Quantity) 
                    FROM ServiceUsage su JOIN Service s ON s.ServiceID = su.ServiceID 
                    WHERE su.BookingID = b.BookingID), 0)
            +
            ISNULL((SELECT SUM(ft.DefaultPrice * bf.Quantity)
                    FROM BookingFee bf JOIN FeeType ft ON ft.FeeTypeID = bf.FeeTypeID
                    WHERE bf.BookingID = b.BookingID), 0)
        )
    FROM Booking b
    JOIN Room r ON r.RoomID = b.RoomID
    JOIN RoomType rt ON rt.RoomTypeID = r.RoomTypeID
    OUTER APPLY (
        SELECT TOP 1 PricePerDay, PricePerHour
        FROM RoomTypePrice p
        WHERE p.RoomTypeID = rt.RoomTypeID
          AND b.CheckIn BETWEEN p.StartDate AND p.EndDate
        ORDER BY p.StartDate DESC
    ) p
    WHERE b.BookingID = @BookingID;

    SET @TotalAfter = @TotalBefore * (1 - @DiscountPercent/100.0);

    -- ✅ Xuất bảng duy nhất, KHÔNG có dòng tổng kết, mà có cột tổng cộng ở cuối
    SELECT 
        X.RowOrder,
        X.Type,
        X.ItemName,
        X.UnitPrice,
        X.Quantity,
        X.PriceBeforeDiscount,
        X.PriceAfterDiscount,
        X.UsedAt,
        c.FullName AS CustomerName,
        c.PhoneNumber,
        ISNULL(rk.RankName, N'Không có') AS RankName,
        @DiscountPercent AS DiscountPercent,
        @TotalBefore AS TotalBeforeDiscount,
        @TotalAfter AS TotalAfterDiscount,
        (@TotalBefore - @TotalAfter) AS DiscountAmount,
        b.BookingID,
        b.CheckIn,
        b.CheckOut
    FROM
    (
        -- Tiền phòng
        SELECT
            1 AS RowOrder,
            N'Tiền phòng' AS Type,
            rt.TypeName AS ItemName,
            CASE WHEN b.RentalType = 'Day' THEN ISNULL(p.PricePerDay, rt.PricePerDay)
                 ELSE ISNULL(p.PricePerHour, rt.PricePerHour) END AS UnitPrice,
            CASE WHEN b.RentalType = 'Day' THEN CEILING(DATEDIFF(HOUR, b.CheckIn, ISNULL(b.CheckOut, GETDATE())) / 24.0)
                 ELSE CEILING(DATEDIFF(HOUR, b.CheckIn, ISNULL(b.CheckOut, GETDATE()))) END AS Quantity,
            CASE WHEN b.RentalType = 'Day' THEN ISNULL(p.PricePerDay, rt.PricePerDay)
                 ELSE ISNULL(p.PricePerHour, rt.PricePerHour) END *
            CASE WHEN b.RentalType = 'Day' THEN CEILING(DATEDIFF(HOUR, b.CheckIn, ISNULL(b.CheckOut, GETDATE())) / 24.0)
                 ELSE CEILING(DATEDIFF(HOUR, b.CheckIn, ISNULL(b.CheckOut, GETDATE()))) END AS PriceBeforeDiscount,
            CASE WHEN b.RentalType = 'Day' THEN ISNULL(p.PricePerDay, rt.PricePerDay)
                 ELSE ISNULL(p.PricePerHour, rt.PricePerHour) END *
            CASE WHEN b.RentalType = 'Day' THEN CEILING(DATEDIFF(HOUR, b.CheckIn, ISNULL(b.CheckOut, GETDATE())) / 24.0)
                 ELSE CEILING(DATEDIFF(HOUR, b.CheckIn, ISNULL(b.CheckOut, GETDATE()))) END * (1 - @DiscountPercent/100.0) AS PriceAfterDiscount,
            b.CheckIn AS UsedAt
        FROM Booking b
        JOIN Room r ON r.RoomID = b.RoomID
        JOIN RoomType rt ON rt.RoomTypeID = r.RoomTypeID
        OUTER APPLY (
            SELECT TOP 1 PricePerDay, PricePerHour
            FROM RoomTypePrice p
            WHERE p.RoomTypeID = rt.RoomTypeID
              AND b.CheckIn BETWEEN p.StartDate AND p.EndDate
            ORDER BY p.StartDate DESC
        ) p
        WHERE b.BookingID = @BookingID

        UNION ALL

        -- Dịch vụ
        SELECT
            2 AS RowOrder,
            N'Dịch vụ',
            s.ServiceName,
            s.Price,
            su.Quantity,
            s.Price * su.Quantity,
            s.Price * su.Quantity * (1 - @DiscountPercent/100.0),
            su.UsageDate
        FROM ServiceUsage su
        JOIN Service s ON s.ServiceID = su.ServiceID
        WHERE su.BookingID = @BookingID

        UNION ALL

        -- Phụ phí
        SELECT
            3 AS RowOrder,
            N'Phụ phí',
            ft.FeeTypeName,
            ft.DefaultPrice,
            bf.Quantity,
            ft.DefaultPrice * bf.Quantity,
            ft.DefaultPrice * bf.Quantity * (1 - @DiscountPercent/100.0),
            bf.CreatedAt
        FROM BookingFee bf
        JOIN FeeType ft ON ft.FeeTypeID = bf.FeeTypeID
        WHERE bf.BookingID = @BookingID
    ) X
    JOIN Booking b ON b.BookingID = @BookingID
    JOIN Customer c ON c.CustomerID = b.CustomerID
    LEFT JOIN CustomerRank rk ON rk.RankID = c.RankID
    ORDER BY X.RowOrder;
END;
GO
CREATE OR ALTER PROCEDURE sp_GetCustomerFullHistory
    @CustomerID CHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @DiscountPercent DECIMAL(5,2) = 0;

    SELECT @DiscountPercent = ISNULL(cr.DiscountPercent, 0)
    FROM Customer c
    LEFT JOIN CustomerRank cr ON c.RankID = cr.RankID
    WHERE c.CustomerID = @CustomerID;

    ----------------------------
    -- Tiền phòng (luôn có dữ liệu)
    ----------------------------
    SELECT
        b.BookingID,
        r.RoomName,
        rt.TypeName AS RoomTypeName,
        c.FullName AS CustomerName,
        i.InvoiceDate,
        i.TotalAmount AS TotalInvoice,
        @DiscountPercent AS DiscountPercent,
        N'Tiền phòng' AS Type,
        ISNULL(
            CASE WHEN b.RentalType = 'Day' THEN ISNULL(p.PricePerDay, rt.PricePerDay)
                 ELSE ISNULL(p.PricePerHour, rt.PricePerHour)
            END, 0
        ) AS UnitPrice,
        CASE 
            WHEN b.RentalType = 'Day' THEN CEILING(DATEDIFF(HOUR, b.CheckIn, ISNULL(b.CheckOut, GETDATE())) / 24.0)
            ELSE CEILING(DATEDIFF(HOUR, b.CheckIn, ISNULL(b.CheckOut, GETDATE())))
        END AS Quantity,
        b.CheckIn AS UsedAt,
        ISNULL(
            (CASE WHEN b.RentalType = 'Day' THEN ISNULL(p.PricePerDay, rt.PricePerDay)
                  ELSE ISNULL(p.PricePerHour, rt.PricePerHour)
            END) *
            (CASE WHEN b.RentalType = 'Day' THEN CEILING(DATEDIFF(HOUR, b.CheckIn, ISNULL(b.CheckOut, GETDATE())) / 24.0)
                  ELSE CEILING(DATEDIFF(HOUR, b.CheckIn, ISNULL(b.CheckOut, GETDATE())))
            END), 0
        ) AS SubTotal
    FROM Booking b
    JOIN Invoice i ON i.BookingID = b.BookingID AND i.PaidStatus = 'Paid'
    JOIN Customer c ON c.CustomerID = b.CustomerID
    JOIN Room r ON r.RoomID = b.RoomID
    JOIN RoomType rt ON rt.RoomTypeID = r.RoomTypeID
    OUTER APPLY (
        SELECT TOP 1 PricePerDay, PricePerHour
        FROM RoomTypePrice p
        WHERE p.RoomTypeID = rt.RoomTypeID
          AND b.CheckIn BETWEEN p.StartDate AND p.EndDate
        ORDER BY p.StartDate DESC
    ) p
    WHERE b.CustomerID = @CustomerID

    UNION ALL

    ----------------------------
    -- Dịch vụ (loại bỏ dòng trống)
    ----------------------------
    SELECT
        b.BookingID,
        r.RoomName,
        rt.TypeName AS RoomTypeName,
        c.FullName AS CustomerName,
        i.InvoiceDate,
        i.TotalAmount AS TotalInvoice,
        @DiscountPercent AS DiscountPercent,
        N'Dịch vụ' AS Type,
        s.Price AS UnitPrice,
        su.Quantity AS Quantity,
        su.UsageDate AS UsedAt,
        (s.Price * su.Quantity) AS SubTotal
    FROM Booking b
    JOIN Invoice i ON i.BookingID = b.BookingID AND i.PaidStatus = 'Paid'
    JOIN ServiceUsage su ON su.BookingID = b.BookingID
    JOIN Service s ON s.ServiceID = su.ServiceID
    JOIN Customer c ON c.CustomerID = b.CustomerID
    JOIN Room r ON r.RoomID = b.RoomID
    JOIN RoomType rt ON rt.RoomTypeID = r.RoomTypeID
    WHERE b.CustomerID = @CustomerID
      AND su.Quantity > 0   -- << CHẶN DÒNG TRỐNG

    UNION ALL

    ----------------------------
    -- Phụ phí (loại bỏ dòng trống)
    ----------------------------
    SELECT
        b.BookingID,
        r.RoomName,
        rt.TypeName AS RoomTypeName,
        c.FullName AS CustomerName,
        i.InvoiceDate,
        i.TotalAmount AS TotalInvoice,
        @DiscountPercent AS DiscountPercent,
        N'Phụ phí' AS Type,
        ft.DefaultPrice AS UnitPrice,
        bf.Quantity AS Quantity,
        bf.CreatedAt AS UsedAt,
        (ft.DefaultPrice * bf.Quantity) AS SubTotal
    FROM Booking b
    JOIN Invoice i ON i.BookingID = b.BookingID AND i.PaidStatus = 'Paid'
    JOIN BookingFee bf ON bf.BookingID = b.BookingID
    JOIN FeeType ft ON ft.FeeTypeID = bf.FeeTypeID
    JOIN Customer c ON c.CustomerID = b.CustomerID
    JOIN Room r ON r.RoomID = b.RoomID
    JOIN RoomType rt ON rt.RoomTypeID = r.RoomTypeID
    WHERE b.CustomerID = @CustomerID
      AND bf.Quantity > 0   -- << CHẶN DÒNG TRỐNG

    ORDER BY BookingID, UsedAt;
END;
GO
CREATE PROCEDURE sp_GetRoomEvaluationTemplate
    @RoomID CHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        r.RoomID AS [Mã phòng],
        r.RoomName AS [Tên phòng],
        ' ' AS [Vệ sinh],
        ' ' AS [Tiện nghi],
        ' ' AS [Phục vụ],
        ' ' AS [Tiện ích],
        ' ' AS [Vị trí],
        ' ' AS [An toàn],
        ' ' AS [Sang trọng],
        ' ' AS [Công nghệ],
        ' ' AS [Nhân viên],
        ' ' AS [Người đánh giá],
        GETDATE() AS [Ngày in báo cáo]
    FROM Room r
    WHERE r.RoomID = @RoomID;
END;
GO


CREATE PROCEDURE GetEquipmentByStatus
    @Status NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        EquipmentID,
        EquipmentName,
        EquipmentCategory,
        Quantity,
        PurchaseDate,
        Status,
        Description,
        StaffID
    FROM 
        EquipmentStorage
    WHERE 
        @Status IS NULL OR Status = @Status
    ORDER BY 
        EquipmentName;
END;
GO
CREATE OR ALTER VIEW v_FactServiceUsage AS
WITH inv_latest AS (
    SELECT i.BookingID, i.InvoiceDate, i.PaidStatus, i.PaymentMethod,
           ROW_NUMBER() OVER (PARTITION BY i.BookingID ORDER BY i.InvoiceDate DESC) AS rn
    FROM Invoice i
)
SELECT
    su.UsageID, su.UsageDate, su.BookingID, su.ServiceID, su.Quantity,
    su.StaffID AS ServiceStaffID,
    b.CustomerID, b.RoomID, b.RentalType, b.CheckIn, b.CheckOut, b.Status AS BookingStatus,
    r.RoomName, r.RoomTypeID, r.Official, rt.TypeName AS RoomTypeName,
    c.FullName AS CustomerName, c.PhoneNumber, c.NationalID,
    cr.RankName, ISNULL(cr.DiscountPercent,0) AS DiscountPercent,
    s.ServiceName, s.Category AS ServiceCategory, s.Price AS UnitPrice,
    st.FullName AS StaffName,
    il.InvoiceDate, il.PaidStatus, il.PaymentMethod,
    CAST(s.Price * su.Quantity AS DECIMAL(18,2)) AS AmountBeforeDiscount,
    CAST(s.Price * su.Quantity * (1 - ISNULL(cr.DiscountPercent,0)/100.0) AS DECIMAL(18,2)) AS AmountAfterDiscount
FROM ServiceUsage su
JOIN Booking b ON b.BookingID = su.BookingID
JOIN Customer c ON c.CustomerID = b.CustomerID
LEFT JOIN CustomerRank cr ON cr.RankID = c.RankID
JOIN Service s ON s.ServiceID = su.ServiceID
LEFT JOIN Staff st ON st.StaffID = su.StaffID
LEFT JOIN Room r ON r.RoomID = b.RoomID
LEFT JOIN RoomType rt ON rt.RoomTypeID = r.RoomTypeID
LEFT JOIN inv_latest il ON il.BookingID = b.BookingID AND il.rn = 1;
GO
CREATE OR ALTER PROCEDURE dbo.sp_ServiceUsage_Detail
    @FromDate     DATE,
    @ToDate       DATE,
    @CustomerText NVARCHAR(100) = NULL,
    @ServiceCat   NVARCHAR(50)  = NULL,
    @StaffID      CHAR(10)      = NULL,
    @RoomID       CHAR(10)      = NULL,
    @OnlyPaid     BIT           = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM v_FactServiceUsage v
    WHERE 
        (@FromDate IS NULL OR v.UsageDate >= @FromDate)
        AND (@ToDate IS NULL OR v.UsageDate < DATEADD(DAY, 1, @ToDate))  -- dùng < ngày kế tiếp

        AND (
                @CustomerText IS NULL
                OR v.CustomerName LIKE N'%' + @CustomerText + N'%'
                OR v.PhoneNumber  LIKE N'%' + @CustomerText + N'%'
                OR v.NationalID   LIKE N'%' + @CustomerText + N'%'
            )

        AND (@ServiceCat IS NULL OR v.ServiceCategory = @ServiceCat)
        AND (@StaffID    IS NULL OR v.ServiceStaffID = @StaffID)
        AND (@RoomID     IS NULL OR v.RoomID = @RoomID)

        AND (
                @OnlyPaid IS NULL
                OR (@OnlyPaid = 1 AND v.PaidStatus = N'Paid')
                OR (@OnlyPaid = 0 AND (v.PaidStatus IS NULL OR v.PaidStatus <> N'Paid'))
            )

    ORDER BY 
        v.ServiceName,
        v.UsageDate,
        v.CustomerName;
END
GO
Exec sp_GetCustomerFullHistory 'CUST6DD9D8'