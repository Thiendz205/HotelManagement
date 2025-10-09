CREATE DATABASE HotelManagement;
GO
USE HotelManagement;
GO
SET DATEFORMAT DMY;
GO
-- Bảng Tài khoản (Account)
CREATE TABLE Account (
    AccountID INT PRIMARY KEY IDENTITY(1,1),                          -- Mã tài khoản (tự tăng)
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
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,        -- Mã khách hàng (tự tăng)
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
    RankName NVARCHAR(50) NOT NULL,             -- Tên hạng (Thường, Silver, Gold...)
    DiscountPercent DECIMAL(5,2) NOT NULL,      -- % giảm giá
    MinSpending DECIMAL(18,2) DEFAULT 0         -- Điều kiện tổng chi tiêu tối thiểu
);
GO

--Bảng RoomType (loại phòng)
CREATE TABLE RoomType (
    RoomTypeID INT IDENTITY(1,1) PRIMARY KEY,   -- Mã loại phòng
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
    RoomTypeID INT NOT NULL,                     -- Loại phòng áp dụng
    StartDate DATE NOT NULL,                     -- Ngày bắt đầu áp dụng
    EndDate DATE NOT NULL,                       -- Ngày kết thúc áp dụng
    PricePerDay DECIMAL(18,2) NOT NULL,          -- Giá thuê theo ngày trong giai đoạn này
    PricePerHour DECIMAL(18,2) NOT NULL,         -- Giá thuê theo giờ trong giai đoạn này
    Note NVARCHAR(max),                          -- Ghi chú (VD: Lễ 30/4-1/5, Giảm giá mùa thấp điểm...)
   
);

-- Bảng Room (Phòng)
CREATE TABLE Room (
    RoomID INT IDENTITY(1,1) PRIMARY KEY,      -- Mã phòng (tự tăng)
    RoomName NVARCHAR(50) NOT NULL,            -- Tên phòng
    RoomTypeID INT NOT NULL,                   -- FK đến loại phòng
    Capacity INT NOT NULL DEFAULT 1,           -- Sức chứa tối đa
    Description NVARCHAR(MAX),                 -- Mô tả thêm
    Status NVARCHAR(20) NOT NULL               -- Trạng thái phòng
        CONSTRAINT DF_Room_Status DEFAULT N'Available'
);
GO

--Bảng đánh giá phòng
CREATE TABLE RoomEvaluation (
    EvaluationID INT IDENTITY(1,1) PRIMARY KEY,
    RoomID INT NOT NULL,                            
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
    EquipmentID INT IDENTITY(1,1) PRIMARY KEY,   -- Mã thiết bị trong kho
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
    RoomEquipmentID INT IDENTITY(1,1) PRIMARY KEY, -- Mã tự tăng
    RoomID INT NOT NULL,                           -- FK đến phòng
    EquipmentStorage INT NOT NULL,                  -- FK đến loại thiết bị
    Quantity INT NOT NULL DEFAULT 1,               -- Số lượng thiết bị
    InstalledDate DATE DEFAULT GETDATE(),          -- Ngày lắp đặt
    Condition NVARCHAR(50) DEFAULT N'Good',        -- Tình trạng (Good, Damaged, Under Maintenance...)
    Note NVARCHAR(max),                             -- Ghi chú thêm
    StaffID char(10)
);
GO

-- Loại phí (dịch vụ, bồi thường, khác) + giá mặc định
CREATE TABLE FeeType (
    FeeTypeID INT IDENTITY(1,1) PRIMARY KEY,
    FeeTypeName NVARCHAR(100) NOT NULL,      -- Tên phí: 'Check-in sớm', 'Thêm giường', 'Hỏng máy lạnh'
    Category NVARCHAR(50) NOT NULL,          -- Nhóm: 'Phụ phí dịch vụ', 'Bồi thường hư hỏng'
    DefaultPrice DECIMAL(18,2) NOT NULL,     -- Giá mặc định cho loại phí này
    Notes NVARCHAR(max)                      -- Ghi chú (nếu cần)
);
GO

-- Các phí phát sinh thực tế của từng booking
CREATE TABLE BookingFee (
    BookingFeeID INT IDENTITY(1,1) PRIMARY KEY,
    BookingID INT NOT NULL,                      -- Liên kết booking
    FeeTypeID INT NOT NULL,                      -- Liên kết loại phí
    Quantity INT NOT NULL DEFAULT 1,             -- Số lượng (VD: 2 khăn tắm bị mất)
    CreatedAt DATETIME DEFAULT GETDATE(),        -- Ngày ghi nhận phí
    Notes NVARCHAR(max),                         -- Ghi chú thêm
);
GO

-- Bảng Booking (Đặt phòng)
CREATE TABLE Booking(
    BookingID INT IDENTITY(1,1) PRIMARY KEY, -- Mã đặt phòng
    CustomerID INT NOT NULL,                 -- Mã khách hàng
    RoomID INT NOT NULL,                     -- Mã phòng
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
    ServiceID INT IDENTITY(1,1) PRIMARY KEY,    -- Mã dịch vụ
    ServiceName NVARCHAR(100) NOT NULL,         -- Tên dịch vụ (Ăn sáng, Giặt ủi…)
    Category NVARCHAR(50),                      -- Nhóm dịch vụ (Ăn uống, Giặt ủi, Vận chuyển…)
    Price DECIMAL(18,2) NOT NULL,               -- Giá dịch vụ
    Description NVARCHAR(200)                   -- Mô tả chi tiết
);
GO

-- Bảng Sử dụng dịch vụ (ServiceUsage)
CREATE TABLE ServiceUsage (
    UsageID INT IDENTITY(1,1) PRIMARY KEY,     -- Mã sử dụng dịch vụ
    BookingID INT NOT NULL,                    -- Mã đặt phòng (liên kết Booking)
    ServiceID INT NOT NULL,                    -- Mã dịch vụ (liên kết Service)
    Quantity INT NOT NULL DEFAULT 1,           -- Số lượng
    StaffID Char(10) NOT NULL                  -- Nhân viên phụ trách dịch vụ
);
GO

-- Bảng Hóa đơn
CREATE TABLE Invoice (
    InvoiceID INT IDENTITY(1,1) PRIMARY KEY, -- Mã hóa đơn
    BookingID INT NOT NULL,                  -- Mã đặt phòng (FK)
    InvoiceDate DATETIME NOT NULL DEFAULT GETDATE(), -- Ngày lập hóa đơn
    TotalAmount DECIMAL(18,2) NOT NULL,      -- Tổng tiền thanh toán
    PaymentMethod NVARCHAR(50) NOT NULL,     -- Hình thức thanh toán (Cash, Card, Transfer...)
    PaidStatus NVARCHAR(20) NOT NULL 
        CONSTRAINT DF_Invoice_PaidStatus DEFAULT N'Unpaid', -- Trạng thái thanh toán
    StaffID CHAR(10) NOT NULL,               -- Nhân viên lập hóa đơn
    Note NVARCHAR(200),                      -- Ghi chú thêm
);

ALTER TABLE Booking 
ADD 
    -- Khóa ngoại liên kết đến bảng Customer (mỗi Booking phải thuộc 1 khách hàng)
    CONSTRAINT FK_Booking_Customer FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),

    -- Khóa ngoại liên kết đến bảng Room (mỗi Booking phải thuộc 1 phòng)
    CONSTRAINT FK_Booking_Room FOREIGN KEY (RoomID) REFERENCES Room(RoomID),

     -- Khóa ngoại liên kết đến bảng Nhân viên (mỗi Booking phải thuộc 1 nhân viên)
    CONSTRAINT FK_Booking_Staff FOREIGN KEY (StaffID) REFERENCES Staff(StaffID);
GO
-- Thêm khóa ngoại cho bảng ServiceUsage
ALTER TABLE ServiceUsage 
ADD 
    -- Khóa ngoại liên kết đến bảng Booking (mỗi lần dùng dịch vụ thuộc về 1 lần đặt phòng)
    CONSTRAINT FK_ServiceUsage_Booking FOREIGN KEY (BookingID) REFERENCES Booking(BookingID),

    -- Khóa ngoại liên kết đến bảng Service (mỗi lần dùng dịch vụ phải chọn 1 dịch vụ)
    CONSTRAINT FK_ServiceUsage_Service FOREIGN KEY (ServiceID) REFERENCES Service(ServiceID),
    
      -- Khóa ngoại liên kết đến bảng Nhân viên (mỗi ServiceUsage phải thuộc 1 nhân viên)
    CONSTRAINT FK_ServiceUsage_Staff FOREIGN KEY (StaffID) REFERENCES Staff(StaffID);
GO

-- Thêm khóa ngoại liên kết đến bảng Staff
ALTER TABLE Account
ADD CONSTRAINT FK_Account_Staff FOREIGN KEY (StaffID) REFERENCES Staff(StaffID);
GO
-- Bảng BookingFee tham chiếu đến Booking và FeeType
ALTER TABLE BookingFee
ADD
    CONSTRAINT FK_BookingFee_Booking FOREIGN KEY (BookingID) REFERENCES Booking(BookingID),  -- Liên kết phí phát sinh với một Booking cụ thể
    CONSTRAINT FK_BookingFee_FeeType FOREIGN KEY (FeeTypeID) REFERENCES FeeType(FeeTypeID);  -- Loại phí (dịch vụ, phụ thu...)
GO

--Bảng khóa ngoại khách sạn
ALTER TABLE Customer
ADD CONSTRAINT FK_Customer_Rank FOREIGN KEY (RankID) REFERENCES CustomerRank(RankID);
GO
-- Bảng Invoice tham chiếu đến Booking và Staff
ALTER TABLE Invoice
ADD
    CONSTRAINT FK_Invoice_Booking FOREIGN KEY (BookingID)  
        REFERENCES Booking(BookingID) 
        ON DELETE CASCADE ON UPDATE CASCADE,   -- Nếu xóa hoặc cập nhật Booking thì hóa đơn cũng thay đổi tương ứng
    CONSTRAINT FK_Invoice_Staff FOREIGN KEY (StaffID)  
        REFERENCES Staff(StaffID);             -- Nhân viên lập hóa đơn
GO
-- Bảng Room tham chiếu đến RoomType
ALTER TABLE Room
ADD
    CONSTRAINT FK_Room_RoomType FOREIGN KEY(RoomTypeID) REFERENCES RoomType(RoomTypeID); -- Mỗi phòng thuộc một loại phòng
GO
ALTER TABLE RoomEquipment
ADD CONSTRAINT FK_RoomEquipment_EquipmentStorage
    FOREIGN KEY (EquipmentStorage) REFERENCES EquipmentStorage(EquipmentID);
GO

ALTER TABLE RoomEquipment
ADD CONSTRAINT FK_RoomEquipment_Staff
    FOREIGN KEY (StaffID) REFERENCES Staff(StaffID);
GO

ALTER TABLE RoomEquipment
ADD CONSTRAINT FK_RoomEquipment_Room
    FOREIGN KEY (RoomID) REFERENCES Room(RoomID);
GO

ALTER TABLE EquipmentStorage
ADD CONSTRAINT FK_EquipmentStorage_Staff
    FOREIGN KEY (StaffID) REFERENCES Staff(StaffID);
GO
ALter table RoomTypePrice
ADD CONSTRAINT FK_RoomTypePrice_RoomType
FOREIGN KEY (RoomTypeID) REFERENCES RoomType(RoomTypeID)

ALTER TABLE RoomEvaluation
ADD CONSTRAINT FK_RoomEvaluation_Room
FOREIGN KEY (RoomID) REFERENCES Room(RoomID) ON DELETE CASCADE ON UPDATE CASCADE;
GO
