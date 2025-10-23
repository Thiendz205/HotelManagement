INSERT INTO Staff (StaffID, FullName, Role, DateOfBirth, Gender, PhoneNumber, CitizenID, StartDate, Notes)
VALUES
('ST001', N'Nguyễn Văn An', N'Lễ Tân', '1985-03-12', N'Male', '0909123456', '012345678901', '2020-01-15', N'Nhân Viên Lễ Tân'),
('ST002', N'Lê Thị Bình', N'Kỹ thuật', '1990-07-25', N'Female', '0909234567', '012345678902', '2021-03-10', N'Nhân Viên Kỹ Thuật'),
('ST003', N'Trần Văn Cảnh', N'Admin' ,'1978-11-02', N'Male', '0909345678', '012345678903', '2018-05-01', N'Quản trị hệ thống'),
('ST004', N'Phạm Thị Dung', N'Dịch vụ', '1982-06-18', N'Female', '0909456789', '012345678904', '2017-09-22', N'Nhân Viên Dịch Vụ'),
('ST005', N'Hoàng Văn Em', N'Dịch vụ', '1995-12-05', N'Male', '0909567890', '012345678905', '2022-02-01', N'Lễ tân ca sáng'),
('ST006', N'Đặng Thị Pha', N'Lễ Tân', '1993-04-11', N'Female', '0909678901', '012345678906', '2021-10-12', N'Nhân Viên Lễ Tân'),
('ST007', N'Vũ Văn Giang', N'Nhân Sự', '1988-08-08', N'Male', '0909789012', '012345678907', '2019-07-20', N'Nhân Viên Nhân Sự'),
('ST008', N'Nguyễn Thị Hương', N'Dịch Vụ', '1991-02-17', N'Female', '0909890123', '012345678908', '2020-08-10', N'Nhân Viên Dịch Vụ');
GO
INSERT INTO Account (Username, Password, StaffID, Status)
VALUES
('receptA', '123456', 'ST001', N'Active'),     
('techB', '123456', 'ST002', N'Active'),       
('adminC', '123456', 'ST003', N'Active'),     
('serviceD', '123456', 'ST004', N'Active'),   
('serviceE', '123456', 'ST005', N'Active'),   
('receptF', '123456', 'ST006', N'Active'),   
('hrG', '123456', 'ST007', N'Inactive'),    
('serviceH', '123456', 'ST008', N'Active'); 
GO
INSERT INTO CustomerRank (RankName, DiscountPercent, MinSpending)
VALUES
(N'Thường', 0.00, 0),          
(N'VIP1', 5.00, 10000000),     
(N'VIP2', 8.00, 30000000),     
(N'VIP3', 10.00, 70000000),       -- Giảm 10%, chi tối thiểu 70 triệu
(N'VIP4', 12.00, 150000000),      -- Giảm 12%, chi tối thiểu 150 triệu
(N'VIP5', 15.00, 300000000);      -- Giảm tối đa 15%, chi tối thiểu 300 triệu
GO
INSERT INTO Customer (FullName, PhoneNumber, NationalID, Address, Country, Gender, DateOfBirth, RankID)
VALUES
(N'Nguyễn Văn An',  '0901000101', '012345679001', N'123 Lý Thường Kiệt, Q.10, TP.HCM', N'Việt Nam', N'Male',   '1990-04-15', 1),
(N'Lê Thị Bình',    '0902000202', '012345679002', N'45 Nguyễn Trãi, Q.5, TP.HCM',      N'Việt Nam', N'Female', '1992-07-10', 2),
(N'Trần Minh Cường','0903000303', '012345679003', N'89 Lê Lợi, Đà Nẵng',               N'Việt Nam', N'Male',   '1988-12-01', 3),
(N'Phạm Thị Dung',  '0904000404', '012345679004', N'12 Hai Bà Trưng, Hà Nội',          N'Việt Nam', N'Female', '1995-09-21', 3),
(N'Hoàng Văn Em',   '0905000505', '012345679005', N'67 Nguyễn Huệ, Huế',               N'Việt Nam', N'Male',   '1985-03-11', 4),
(N'Đặng Thị Hoa',   '0906000606', '012345679006', N'23 Phan Đình Phùng, Q.3, TP.HCM',  N'Việt Nam', N'Female', '1993-06-28', 4),
(N'Vũ Văn Khánh',   '0907000707', '012345679007', N'78 Trường Chinh, Hà Nội',          N'Việt Nam', N'Male',   '1980-01-20', 5),
(N'Nguyễn Thị Lan', '0908000808', '012345679008', N'9 Trần Phú, Đà Lạt',               N'Việt Nam', N'Female', '1991-11-12', 5),
(N'Bùi Quốc Minh',  '0909000909', '012345679009', N'25 Cách Mạng Tháng 8, TP.HCM',     N'Việt Nam', N'Male',   '1987-02-08', 6),
(N'Phan Thị Ngọc',  '0910001010', '012345679010', N'56 Pasteur, Q.1, TP.HCM',          N'Việt Nam', N'Female', '1994-10-05', 6),
(N'John Smith',     '0981001101', 'P1234567891',  N'221B Baker Street, London',       N'Anh',       N'Male',   '1982-09-13', 2),
(N'Emily Johnson',  '0982002202', 'P1234567892',  N'742 Evergreen Terrace, Springfield', N'Mỹ',    N'Female', '1989-01-24', 3),
(N'Yamada Taro',    '0983003303', 'P1234567893',  N'1-2-3 Shibuya, Tokyo',             N'Nhật Bản',  N'Male',   '1979-03-05', 4),
(N'Sakura Tanaka',  '0984004404', 'P1234567894',  N'5-6-7 Akihabara, Tokyo',           N'Nhật Bản',  N'Female', '1992-07-19', 5),
(N'Park Ji-hoon',   '0985005505', 'P1234567895',  N'88 Gangnam, Seoul',                N'Hàn Quốc',  N'Male',   '1987-12-10', 3),
(N'Kim Soo-jin',    '0986006606', 'P1234567896',  N'12 Itaewon, Seoul',                N'Hàn Quốc',  N'Female', '1990-02-15', 4),
(N'Liu Wei',        '0987007707', 'P1234567897',  N'56 Nanjing Road, Shanghai',        N'Trung Quốc',N'Male',   '1984-05-22', 5),
(N'Anna Müller',    '0988008808', 'P1234567898',  N'22 Hauptstraße, Berlin',           N'Đức',       N'Female', '1986-09-30', 2),
(N'Maria Rossi',    '0989009909', 'P1234567899',  N'10 Via Roma, Milano',              N'Ý',         N'Female', '1991-04-04', 6),
(N'Carlos Silva',   '0990000000', 'P1234567900',  N'55 Avenida Paulista, São Paulo',   N'Brazil',    N'Male',   '1983-11-08', 5);
GO
INSERT INTO RoomType (TypeName, PricePerDay, PricePerHour, Category, Description)
VALUES
(N'Phòng Đơn', 400000, 60000, N'Standard', N'Phòng 1 giường đơn, phù hợp cho 1 người.'),
(N'Phòng Đôi', 700000, 100000, N'Standard', N'Phòng 1 giường đôi hoặc 2 giường đơn, cho 2 người.'),
(N'Phòng Đa',  1200000, 180000, N'Standard', N'Phòng nhiều giường, phù hợp cho gia đình hoặc nhóm bạn.');
GO
INSERT INTO RoomTypePrice (RoomTypeID, StartDate, EndDate, PricePerDay, PricePerHour, Note)
VALUES
(1, '2025-01-01', '2025-04-29', 400000, 60000,  N'Giá mùa thường'),
(1, '2025-04-30', '2025-05-02', 500000, 80000,  N'Lễ 30/4 - 1/5'),
(1, '2025-05-03', '2025-09-30', 380000, 55000,  N'Giảm giá mùa thấp điểm'),
(2, '2025-01-01', '2025-04-29', 700000, 100000, N'Giá mùa thường'),
(2, '2025-04-30', '2025-05-02', 850000, 120000, N'Lễ 30/4 - 1/5'),
(2, '2025-05-03', '2025-09-30', 650000, 90000,  N'Giảm giá mùa thấp điểm'),
(3, '2025-01-01', '2025-04-29', 1200000, 180000, N'Giá mùa thường'),
(3, '2025-04-30', '2025-05-02', 1500000, 220000, N'Lễ 30/4 - 1/5'),
(3, '2025-05-03', '2025-09-30', 1100000, 160000, N'Giảm giá mùa thấp điểm');
GO
INSERT INTO Room (RoomName, RoomTypeID, Capacity, Description, Status)
VALUES
(N'Đơn-101', 1, 1, N'Phòng đơn tầng 1, có cửa sổ', N'Trống'),
(N'Đơn-102', 1, 1, N'Phòng đơn tầng 1, gần thang máy', N'Đặt trước'),
(N'Đơn-103', 1, 1, N'Phòng đơn tầng 1, yên tĩnh, view vườn', N'Đang hoạt động'),
(N'Đơn-104', 1, 1, N'Phòng đơn tầng 1, có bàn làm việc', N'Dọn dẹp'),
(N'Đơn-105', 1, 1, N'Phòng đơn tầng 1, tường cách âm tốt', N'Trống'),
(N'Đơn-106', 1, 1, N'Phòng đơn tầng 1, có mini bar', N'Đang bảo trì'),
(N'Đơn-107', 1, 1, N'Phòng đơn tầng 1, gần lễ tân', N'Trống'),
(N'Đơn-108', 1, 1, N'Phòng đơn tầng 1, hướng Tây Nam', N'Đặt trước'),
(N'Đơn-109', 1, 1, N'Phòng đơn tầng 1, có tivi và wifi mạnh', N'Đang hoạt động'),
(N'Đơn-110', 1, 1, N'Phòng đơn tầng 1, sạch sẽ, thoáng mát', N'Dọn dẹp'),
(N'Đôi-201', 2, 2, N'Phòng đôi tầng 2, có ban công', N'Trống'),
(N'Đôi-202', 2, 2, N'Phòng đôi tầng 2, view hồ bơi', N'Đặt trước'),
(N'Đôi-203', 2, 2, N'Phòng đôi tầng 2, có bồn tắm', N'Đang hoạt động'),
(N'Đôi-204', 2, 2, N'Phòng đôi tầng 2, gần cầu thang bộ', N'Dọn dẹp'),
(N'Đôi-205', 2, 2, N'Phòng đôi tầng 2, có ghế sofa', N'Đang bảo trì'),
(N'Đôi-206', 2, 2, N'Phòng đôi tầng 2, yên tĩnh, nhiều ánh sáng', N'Trống'),
(N'Đôi-207', 2, 2, N'Phòng đôi tầng 2, tầm nhìn hướng vườn', N'Đặt trước'),
(N'Đôi-208', 2, 2, N'Phòng đôi tầng 2, có tủ lạnh mini', N'Đang hoạt động'),
(N'Đôi-209', 2, 2, N'Phòng đôi tầng 2, gần khu giải trí', N'Dọn dẹp'),
(N'Đôi-210', 2, 2, N'Phòng đôi tầng 2, nội thất mới', N'Trống'),
(N'Đa-301', 3, 4, N'Phòng đa tầng 3, 2 giường đôi, view biển', N'Trống'),
(N'Đa-302', 3, 4, N'Phòng đa tầng 3, có sofa và minibar', N'Đặt trước'),
(N'Đa-303', 3, 4, N'Phòng đa tầng 3, có ban công rộng', N'Đang hoạt động'),
(N'Đa-304', 3, 4, N'Phòng đa tầng 3, cần dọn dẹp lại', N'Dọn dẹp'),
(N'Đa-305', 3, 4, N'Phòng đa tầng 3, có khu vực tiếp khách', N'Đang bảo trì'),
(N'Đa-306', 3, 4, N'Phòng đa tầng 3, gần thang máy', N'Trống'),
(N'Đa-307', 3, 4, N'Phòng đa tầng 3, có nhà bếp nhỏ', N'Đặt trước'),
(N'Đa-308', 3, 4, N'Phòng đa tầng 3, rộng rãi thoáng mát', N'Đang hoạt động'),
(N'Đa-309', 3, 4, N'Phòng đa tầng 3, có bàn ăn riêng', N'Dọn dẹp'),
(N'Đa-310', 3, 4, N'Phòng đa tầng 3, nội thất cao cấp', N'Trống');
GO
INSERT INTO RoomEvaluation 
(RoomID, EvaluationDate, CleanlinessScore, ComfortScore, ServiceScore, FacilitiesScore, LocationScore, SafetyScore, LuxuryScore, TechnologyScore, StaffScore, Evaluator)
VALUES
(1, '2025-09-15', 8, 7, 9, 7, 8, 9, 6, 7, 8, N'Nguyễn Văn An'),
(2, '2025-09-20', 7, 8, 8, 6, 8, 8, 6, 6, 8, N'Nguyễn Văn An'),
(3, '2025-09-25', 9, 9, 9, 8, 9, 9, 7, 7, 9, N'Nguyễn Văn An'),
(4, '2025-09-27', 8, 8, 8, 7, 8, 8, 6, 6, 8, N'Phạm Thị Dung'),
(5, '2025-10-01', 9, 8, 9, 8, 8, 9, 7, 7, 9, N'Phạm Thị Dung'),
(11, '2025-09-10', 8, 9, 9, 8, 9, 9, 8, 8, 9, N'Phạm Thị Dung'),
(12, '2025-09-18', 9, 8, 8, 8, 8, 9, 7, 7, 8, N'Lê Hồng Linh'),
(13, '2025-09-23', 10, 9, 9, 9, 9, 10, 8, 9, 9, N'Lê Hồng Linh'),
(14, '2025-09-25', 7, 7, 8, 6, 7, 8, 6, 6, 7, N'Lê Hồng Linh'),
(15, '2025-10-03', 8, 8, 9, 8, 8, 9, 7, 8, 9, N'Lê Hồng Linh');
GO
INSERT INTO EquipmentStorage (EquipmentName, EquipmentCategory, Quantity, PurchaseDate, Status, Description, StaffID)
VALUES
(N'Giường đôi cao cấp', N'Nội thất', 20, '2024-02-01', N'Available', N'Giường gỗ sồi nhập khẩu, nệm cao su thiên nhiên', 'ST001'),
(N'Tủ quần áo 3 cánh', N'Nội thất', 25, '2024-03-15', N'Available', N'Tủ gỗ công nghiệp phủ melamine chống ẩm', 'ST002'),
(N'Bàn trang điểm', N'Nội thất', 15, '2024-01-20', N'Available', N'Bàn có gương và đèn LED tích hợp', 'ST003'),
(N'Ghế sofa đôi', N'Nội thất', 12, '2023-12-10', N'In Use', N'Ghế đặt tại phòng Suite và Deluxe', 'ST004'),
(N'Tivi Smart 43 inch', N'Điện tử', 30, '2024-04-05', N'Available', N'Tivi kết nối internet, có Netflix và YouTube', 'ST005'),
(N'Máy lạnh Daikin', N'Điện tử', 20, '2023-11-25', N'Maintenance', N'Đang bảo trì định kỳ tháng 10', 'ST006'),
(N'Tủ lạnh mini', N'Điện tử', 25, '2024-02-12', N'Available', N'Dung tích 90L, cho phòng Deluxe trở lên', 'ST002'),
(N'Két sắt điện tử', N'Tiện ích', 18, '2024-03-01', N'Available', N'Dùng mã PIN, bảo mật cao', 'ST003'),
(N'Máy sấy tóc', N'Tiện ích', 40, '2024-05-10', N'Available', N'Máy sấy công suất 1800W, có 2 chế độ nhiệt', 'ST001'),
(N'Ấm đun nước siêu tốc', N'Tiện ích', 35, '2024-06-20', N'In Use', N'Ấm Inox, dung tích 1.5L', 'ST005');
GO
INSERT INTO RoomEquipment (RoomID, EquipmentStorage, Quantity, InstalledDate, Condition, Note, StaffID)
VALUES
(1, 1, 1, '2024-03-10', N'Good', N'Giường đôi tiêu chuẩn', 'ST001'),
(1, 5, 1, '2024-03-10', N'Good', N'Tivi Smart kết nối ổn định', 'ST005'),
(2, 7, 1, '2024-03-15', N'Good', N'Tủ lạnh mini hoạt động tốt', 'ST002'),
(3, 9, 1, '2024-04-05', N'Good', N'Máy sấy tóc mới', 'ST001'),
(4, 10, 1, '2024-04-12', N'Good', N'Ấm đun nước mới thay', 'ST005'),
(5, 2, 1, '2024-04-20', N'Good', N'Tủ quần áo đủ ngăn chứa', 'ST002'),
(6, 1, 1, '2024-03-18', N'Good', N'Giường cao cấp', 'ST001'),
(6, 5, 1, '2024-03-18', N'Good', N'Tivi Smart 43"', 'ST005'),
(7, 3, 1, '2024-03-25', N'Good', N'Bàn trang điểm có đèn LED', 'ST003'),
(8, 7, 1, '2024-03-30', N'Good', N'Tủ lạnh mini có đồ uống', 'ST002'),
(9, 8, 1, '2024-04-02', N'Good', N'Két sắt điện tử trong tủ quần áo', 'ST003'),
(10, 9, 1, '2024-04-10', N'Good', N'Máy sấy tóc Philips', 'ST001'),
(11, 1, 1, '2024-02-05', N'Good', N'Giường lớn King Size', 'ST001'),
(12, 4, 1, '2024-02-15', N'Good', N'Ghế sofa đôi da cao cấp', 'ST004'),
(13, 5, 1, '2024-03-01', N'Good', N'Tivi Smart kết nối Netflix', 'ST005'),
(14, 6, 1, '2024-03-12', N'Maintenance', N'Máy lạnh đang bảo dưỡng', 'ST006'),
(15, 8, 1, '2024-03-22', N'Good', N'Két sắt điện tử an toàn', 'ST003'),
(16, 1, 1, '2024-02-28', N'Good', N'Giường cao cấp nhập khẩu', 'ST001'),
(17, 4, 1, '2024-03-03', N'Good', N'Sofa đôi đặt cạnh cửa sổ', 'ST004'),
(18, 5, 1, '2024-03-08', N'Good', N'Tivi Smart 43" UHD', 'ST005'),
(19, 8, 1, '2024-03-10', N'Good', N'Két sắt điện tử mã số riêng', 'ST003'),
(20, 10, 1, '2024-03-15', N'Good', N'Ấm siêu tốc sang trọng', 'ST005');
GO
INSERT INTO FeeType (FeeTypeName, Category, DefaultPrice, Notes)
VALUES
(N'Check-in sớm',       N'Phụ Phí', 200000, N'Tính thêm nếu khách vào trước 12h trưa'),
(N'Check-out trễ',      N'Phụ Phí', 250000, N'Tính thêm nếu khách ra sau 14h'),
(N'Thêm giường phụ',    N'Phụ Phí', 300000, N'Thêm 1 giường gấp trong phòng'),
(N'Dịch vụ giặt ủi',    N'Phụ Phí', 80000,  N'Tính theo mỗi lần giặt ủi'),
(N'Hỏng TV',            N'Bồi Thường', 2500000, N'Bồi thường khi khách làm hư TV'),
(N'Hỏng máy lạnh',      N'Bồi Thường', 3500000, N'Sửa chữa hoặc thay mới máy lạnh'),
(N'Vỡ gương phòng tắm', N'Bồi Thường', 500000,  N'Tính phí khi gương bị vỡ'),
(N'Phí nâng cấp phòng', N'Khác', 400000, N'Khách yêu cầu nâng cấp từ Standard → Deluxe'),
(N'Phí mất thẻ phòng',  N'Khác', 150000, N'Mất thẻ từ hoặc chìa khóa phòng');
GO
INSERT INTO Booking (CustomerID, RoomID, RentalType, CheckIn, CheckOut, Price, Status, StaffID)
VALUES
(1, 1, N'Day', '2025-10-10 13:00', '2025-10-12 11:00', 500000, N'CheckOut', 'ST001'),
(2, 2, N'Day', '2025-10-13 14:00', '2025-10-14 12:00', 500000, N'CheckOut', 'ST002'),
(3, 3, N'Day', '2025-10-14 15:00', '2025-10-16 12:00', 800000, N'CheckOut', 'ST003'),
(4, 6, N'Day', '2025-10-15 12:00', NULL,               1200000, N'CheckIn', 'ST004'),
(5, 7, N'Day', '2025-10-15 13:00', NULL,               1200000, N'CheckIn', 'ST005'),
(6, 10, N'Day', '2025-10-14 14:00', '2025-10-15 12:00', 1500000, N'CheckOut', 'ST006'),
(7, 12, N'Hour', '2025-10-15 09:00', '2025-10-15 14:00', 150000, N'CheckOut', 'ST002'),
(8, 13, N'Hour', '2025-10-15 10:00', NULL,               180000, N'CheckIn', 'ST001'),
(9, 14, N'Hour', '2025-10-15 12:00', NULL,               180000, N'CheckIn', 'ST003'),
(10, 15, N'Hour', '2025-10-15 08:00', '2025-10-15 11:00', 180000, N'CheckOut', 'ST004');
GO
INSERT INTO BookingFee (BookingID, FeeTypeID, Quantity, Notes)
VALUES
(1, 1, 1, N'Khách vào lúc 9h sáng – Check-in sớm'),
(2, 2, 1, N'Khách trả phòng lúc 16h – Check-out trễ'),
(3, 3, 1, N'Thêm giường phụ cho trẻ nhỏ'),
(4, 4, 2, N'Khách gửi giặt 2 bộ quần áo'),
(5, 5, 1, N'TV hỏng do rơi điều khiển'),
(6, 6, 1, N'Máy lạnh không hoạt động sau khi khách rời phòng'),
(7, 7, 1, N'Gương phòng tắm bị vỡ'),
(8, 8, 1, N'Nâng cấp phòng từ Deluxe lên Suite'),
(9, 9, 1, N'Mất thẻ phòng khi trả');
GO
INSERT INTO Service (ServiceName, Category, Price, Description)
VALUES
(N'Ăn sáng buffet',     N'Ăn uống',       150000, N'Buffet sáng phục vụ từ 6h - 9h'),
(N'Giặt ủi quần áo',    N'Giặt ủi',        50000,  N'Tính theo mỗi kg quần áo'),
(N'Đưa đón sân bay',    N'Vận chuyển',    300000, N'Đưa đón sân bay bằng xe riêng'),
(N'Massage thư giãn',   N'Spa',           400000, N'Massage toàn thân 60 phút'),
(N'Thuê xe máy',        N'Vận chuyển',    200000, N'Thuê xe máy theo ngày'),
(N'Gọi món tại phòng',  N'Ăn uống',       100000, N'Phục vụ đồ ăn tận phòng'),
(N'Sauna & xông hơi',   N'Spa',           250000, N'Trọn gói 45 phút'),
(N'Thuê phòng họp',     N'Dịch vụ khác',  800000, N'Phòng họp tối đa 20 người, có máy chiếu');
GO
INSERT INTO ServiceUsage (BookingID, ServiceID, Quantity, StaffID, UsageDate)
VALUES
(1, 1, 2, 'ST001', '2025-10-20 08:30:00'),
(1, 2, 1, 'ST005', '2025-10-20 09:00:00'),
(2, 3, 1, 'ST002', '2025-10-21 14:15:00'),
(3, 5, 2, 'ST004', '2025-10-22 10:45:00'),
(4, 4, 1, 'ST006', '2025-10-22 11:10:00'),
(5, 6, 3, 'ST001', '2025-10-23 16:30:00'),
(6, 1, 1, 'ST003', '2025-10-23 17:00:00'),
(7, 2, 2, 'ST005', '2025-10-24 08:00:00'),
(8, 4, 1, 'ST002', '2025-10-24 09:45:00'),
(9, 6, 1, 'ST004', '2025-10-25 10:20:00');
GO
INSERT INTO Invoice (BookingID, TotalAmount, PaymentMethod, PaidStatus, StaffID, Note)
VALUES
(1, 1500000, N'Tiền mặt', N'Paid', 'ST001', N'Khách thanh toán đầy đủ'),
(2, 2300000, N'Thẻ',      N'Paid', 'ST004', N'Thanh toán bằng thẻ VISA'),
(3, 900000,  N'Tiền mặt', N'Unpaid', 'ST002', N'Chưa thanh toán phí dịch vụ'),
(4, 3500000, N'Chuyển khoản', N'Paid', 'ST005', N'Khách công ty thanh toán qua ngân hàng'),
(5, 2750000, N'Thẻ', N'Paid', 'ST003', N'Đã bao gồm phí nâng cấp phòng');
GO