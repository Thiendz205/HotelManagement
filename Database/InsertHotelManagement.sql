INSERT INTO Staff (StaffID, FullName, Role, DateOfBirth, Gender, PhoneNumber, CitizenID, StartDate, Notes)
VALUES
('ST001', N'Nguyễn Văn An',     N'Lễ tân',     '1985-03-12', N'Male',   '0909123456', '012345678901', '2020-01-15', N'Nhân viên lễ tân'),
('ST002', N'Lê Thị Bình',       N'Kỹ thuật',   '1990-07-25', N'Female', '0909234567', '012345678902', '2021-03-10', N'Nhân viên kỹ thuật'),
('ST003', N'Trần Văn Cảnh',     N'Admin',      '1978-11-02', N'Male',   '0909345678', '012345678903', '2018-05-01', N'Quản trị hệ thống'),
('ST004', N'Phạm Thị Dung',     N'Dịch vụ',    '1982-06-18', N'Female', '0909456789', '012345678904', '2017-09-22', N'Nhân viên dịch vụ'),
('ST005', N'Hoàng Văn Em',      N'Dịch vụ',    '1995-12-05', N'Male',   '0909567890', '012345678905', '2022-02-01', N'Lễ tân ca sáng'),
('ST006', N'Đặng Thị Pha',      N'Lễ tân',     '1993-04-11', N'Female', '0909678901', '012345678906', '2021-10-12', N'Nhân viên lễ tân'),
('ST007', N'Vũ Văn Giang',      N'Nhân sự',    '1988-08-08', N'Male',   '0909789012', '012345678907', '2019-07-20', N'Nhân viên nhân sự'),
('ST008', N'Nguyễn Thị Hương',  N'Dịch vụ',    '1991-02-17', N'Female', '0909890123', '012345678908', '2020-08-10', N'Nhân viên dịch vụ');
GO
INSERT INTO Account (Username, [Password], StaffID, [Status])
VALUES
('receptA',  'Recept@1', 'ST001', N'Active'),
('techB',    'Tech@12',  'ST002', N'Active'),
('adminC',   'Admin#9',  'ST003', N'Active'),
('serviceD', 'Service@3','ST004', N'Active'),
('serviceE', 'Service#4','ST005', N'Active'),
('receptF',  'Recept@5', 'ST006', N'Active'),
('hrG',      'Hr#2024',  'ST007', N'Inactive'),
('serviceH', 'Service!6','ST008', N'Active');
GO
INSERT INTO CustomerRank (RankName, DiscountPercent, MinSpending)
VALUES
(N'Thường', 0.00, 0),
(N'VIP1', 5.00, 10000000),
(N'VIP2', 8.00, 30000000),
(N'VIP3', 10.00, 70000000),
(N'VIP4', 12.00, 150000000),
(N'VIP5', 15.00, 300000000);
GO
INSERT INTO Customer (CustomerID, FullName, PhoneNumber, NationalID, Address, Country, Gender, DateOfBirth, RankID)
VALUES
('CU001', N'Nguyễn Văn An',     '0901000101', '012345679001', N'123 Lý Thường Kiệt, Q.10, TP.HCM',        N'Việt Nam', N'Male',   '1990-04-15', 1),
('CU002', N'Lê Thị Bình',       '0902000202', '012345679002', N'45 Nguyễn Trãi, Q.5, TP.HCM',             N'Việt Nam', N'Female', '1992-07-10', 2),
('CU003', N'Trần Minh Cường',   '0903000303', '012345679003', N'89 Lê Lợi, Đà Nẵng',                      N'Việt Nam', N'Male',   '1988-12-01', 3),
('CU004', N'Phạm Thị Dung',     '0904000404', '012345679004', N'12 Hai Bà Trưng, Hà Nội',                 N'Việt Nam', N'Female', '1995-09-21', 3),
('CU005', N'Hoàng Văn Em',      '0905000505', '012345679005', N'67 Nguyễn Huệ, Huế',                      N'Việt Nam', N'Male',   '1985-03-11', 4),
('CU006', N'Đặng Thị Hoa',      '0906000606', '012345679006', N'23 Phan Đình Phùng, Q.3, TP.HCM',         N'Việt Nam', N'Female', '1993-06-28', 4),
('CU007', N'Vũ Văn Khánh',      '0907000707', '012345679007', N'78 Trường Chinh, Hà Nội',                 N'Việt Nam', N'Male',   '1980-01-20', 5),
('CU008', N'Nguyễn Thị Lan',    '0908000808', '012345679008', N'9 Trần Phú, Đà Lạt',                      N'Việt Nam', N'Female', '1991-11-12', 5),
('CU009', N'Bùi Quốc Minh',     '0909000909', '012345679009', N'25 Cách Mạng Tháng 8, TP.HCM',            N'Việt Nam', N'Male',   '1987-02-08', 6),
('CU010', N'Phan Thị Ngọc',     '0910001010', '012345679010', N'56 Pasteur, Q.1, TP.HCM',                 N'Việt Nam', N'Female', '1994-10-05', 6),
('CU011', N'John Smith',        '0981001101', '123456789101', N'221B Baker Street, London',               N'Anh',       N'Male',   '1982-09-13', 2),
('CU012', N'Emily Johnson',     '0982002202', '123456789102', N'742 Evergreen Terrace, Springfield',      N'Mỹ',        N'Female', '1989-01-24', 3),
('CU013', N'Yamada Taro',       '0983003303', '123456789103', N'1-2-3 Shibuya, Tokyo',                    N'Nhật Bản',  N'Male',   '1979-03-05', 4),
('CU014', N'Sakura Tanaka',     '0984004404', '123456789104', N'5-6-7 Akihabara, Tokyo',                  N'Nhật Bản',  N'Female', '1992-07-19', 5),
('CU015', N'Park Ji-hoon',      '0985005505', '123456789105', N'88 Gangnam, Seoul',                       N'Hàn Quốc',  N'Male',   '1987-12-10', 3),
('CU016', N'Kim Soo-jin',       '0986006606', '123456789106', N'12 Itaewon, Seoul',                       N'Hàn Quốc',  N'Female', '1990-02-15', 4),
('CU017', N'Liu Wei',           '0987007707', '123456789107', N'56 Nanjing Road, Shanghai',               N'Trung Quốc',N'Male',   '1984-05-22', 5),
('CU018', N'Anna Müller',       '0988008808', '123456789108', N'22 Hauptstraße, Berlin',                  N'Đức',       N'Female', '1986-09-30', 2),
('CU019', N'Maria Rossi',       '0989009909', '123456789109', N'10 Via Roma, Milano',                     N'Ý',         N'Female', '1991-04-04', 6),
('CU020', N'Carlos Silva',      '0990000000', '123456789110', N'55 Avenida Paulista, São Paulo',          N'Brazil',    N'Male',   '1983-11-08', 5);
GO

INSERT INTO RoomType (RoomTypeID, TypeName, PricePerDay, PricePerHour, Category, Description)
VALUES
('RT001', N'Phòng Đơn', 400000, 60000, N'Standard', N'Phòng 1 giường đơn, phù hợp cho 1 người.'),
('RT002', N'Phòng Đôi', 700000, 100000, N'Standard', N'Phòng 1 giường đôi hoặc 2 giường đơn, cho 2 người.'),
('RT003', N'Phòng Đa', 1200000, 180000, N'Standard', N'Phòng nhiều giường, phù hợp cho gia đình hoặc nhóm bạn.');
GO

INSERT INTO RoomTypePrice (RoomTypeID, StartDate, EndDate, PricePerDay, PricePerHour, Note)
VALUES
('RT001', '2025-01-01', '2025-04-29', 400000, 60000, N'Giá mùa thường'),
('RT001', '2025-04-30', '2025-05-02', 500000, 80000, N'Lễ 30/4 - 1/5'),
('RT001', '2025-05-03', '2025-09-30', 380000, 55000, N'Giảm giá mùa thấp điểm'),
('RT002', '2025-01-01', '2025-04-29', 700000, 100000, N'Giá mùa thường'),
('RT002', '2025-04-30', '2025-05-02', 850000, 120000, N'Lễ 30/4 - 1/5'),
('RT002', '2025-05-03', '2025-09-30', 650000, 90000, N'Giảm giá mùa thấp điểm'),
('RT003', '2025-01-01', '2025-04-29', 1200000, 180000, N'Giá mùa thường'),
('RT003', '2025-04-30', '2025-05-02', 1500000, 220000, N'Lễ 30/4 - 1/5'),
('RT003', '2025-05-03', '2025-09-30', 1100000, 160000, N'Giảm giá mùa thấp điểm');
GO
INSERT INTO Room (RoomID, RoomName, RoomTypeID, Capacity, Description, Status, Official)
VALUES
('R001', N'Đơn-101', 'RT001', 1, N'Phòng đơn tầng 1, có cửa sổ', N'Trống', N'Đã chứng thực'),
('R002', N'Đơn-102', 'RT001', 1, N'Phòng đơn tầng 1, gần thang máy', N'Đặt trước', N'Chưa chứng thực'),
('R003', N'Đơn-103', 'RT001', 1, N'Phòng đơn tầng 1, yên tĩnh, view vườn', N'Đang hoạt động', N'Đã chứng thực'),
('R004', N'Đơn-104', 'RT001', 1, N'Phòng đơn tầng 1, có bàn làm việc', N'Dọn dẹp', N'Chưa chứng thực'),
('R005', N'Đơn-105', 'RT001', 1, N'Phòng đơn tầng 1, tường cách âm tốt', N'Trống', N'Đã chứng thực'),
('R006', N'Đơn-106', 'RT001', 1, N'Phòng đơn tầng 1, có mini bar', N'Đang bảo trì', N'Chưa chứng thực'),
('R007', N'Đơn-107', 'RT001', 1, N'Phòng đơn tầng 1, gần lễ tân', N'Trống', N'Đã chứng thực'),
('R008', N'Đơn-108', 'RT001', 1, N'Phòng đơn tầng 1, hướng Tây Nam', N'Đặt trước', N'Chưa chứng thực'),
('R009', N'Đơn-109', 'RT001', 1, N'Phòng đơn tầng 1, có tivi và wifi mạnh', N'Đang hoạt động', N'Đã chứng thực'),
('R010', N'Đơn-110', 'RT001', 1, N'Phòng đơn tầng 1, sạch sẽ, thoáng mát', N'Dọn dẹp', N'Chưa chứng thực'),

('R011', N'Đôi-201', 'RT002', 2, N'Phòng đôi tầng 2, có ban công', N'Trống', N'Đã chứng thực'),
('R012', N'Đôi-202', 'RT002', 2, N'Phòng đôi tầng 2, view hồ bơi', N'Đặt trước', N'Chưa chứng thực'),
('R013', N'Đôi-203', 'RT002', 2, N'Phòng đôi tầng 2, có bồn tắm', N'Đang hoạt động', N'Đã chứng thực'),
('R014', N'Đôi-204', 'RT002', 2, N'Phòng đôi tầng 2, gần cầu thang bộ', N'Dọn dẹp', N'Chưa chứng thực'),
('R015', N'Đôi-205', 'RT002', 2, N'Phòng đôi tầng 2, có ghế sofa', N'Đang bảo trì', N'Đã chứng thực'),
('R016', N'Đôi-206', 'RT002', 2, N'Phòng đôi tầng 2, yên tĩnh, nhiều ánh sáng', N'Trống', N'Đã chứng thực'),
('R017', N'Đôi-207', 'RT002', 2, N'Phòng đôi tầng 2, tầm nhìn hướng vườn', N'Đặt trước', N'Chưa chứng thực'),
('R018', N'Đôi-208', 'RT002', 2, N'Phòng đôi tầng 2, có tủ lạnh mini', N'Đang hoạt động', N'Đã chứng thực'),
('R019', N'Đôi-209', 'RT002', 2, N'Phòng đôi tầng 2, gần khu giải trí', N'Dọn dẹp', N'Chưa chứng thực'),
('R020', N'Đôi-210', 'RT002', 2, N'Phòng đôi tầng 2, nội thất mới', N'Trống', N'Đã chứng thực'),

('R021', N'Đa-301', 'RT003', 4, N'Phòng đa tầng 3, 2 giường đôi, view biển', N'Trống', N'Đã chứng thực'),
('R022', N'Đa-302', 'RT003', 4, N'Phòng đa tầng 3, có sofa và minibar', N'Đặt trước', N'Chưa chứng thực'),
('R023', N'Đa-303', 'RT003', 4, N'Phòng đa tầng 3, có ban công rộng', N'Đang hoạt động', N'Đã chứng thực'),
('R024', N'Đa-304', 'RT003', 4, N'Phòng đa tầng 3, cần dọn dẹp lại', N'Dọn dẹp', N'Chưa chứng thực'),
('R025', N'Đa-305', 'RT003', 4, N'Phòng đa tầng 3, có khu vực tiếp khách', N'Đang bảo trì', N'Đã chứng thực'),
('R026', N'Đa-306', 'RT003', 4, N'Phòng đa tầng 3, gần thang máy', N'Trống', N'Đã chứng thực'),
('R027', N'Đa-307', 'RT003', 4, N'Phòng đa tầng 3, có nhà bếp nhỏ', N'Đặt trước', N'Chưa chứng thực'),
('R028', N'Đa-308', 'RT003', 4, N'Phòng đa tầng 3, rộng rãi thoáng mát', N'Đang hoạt động', N'Đã chứng thực'),
('R029', N'Đa-309', 'RT003', 4, N'Phòng đa tầng 3, có bàn ăn riêng', N'Dọn dẹp', N'Chưa chứng thực'),
('R030', N'Đa-310', 'RT003', 4, N'Phòng đa tầng 3, nội thất cao cấp', N'Trống', N'Đã chứng thực');
GO

INSERT INTO RoomEvaluation
(RoomID, EvaluationDate, CleanlinessScore, ComfortScore, ServiceScore, FacilitiesScore, LocationScore, SafetyScore, LuxuryScore, TechnologyScore, StaffScore, Evaluator)
VALUES
('R001', '2025-09-10', 8, 7, 8, 7, 8, 8, 6, 6, 8, N'Nguyễn Văn An'),
('R002', '2025-09-12', 7, 7, 7, 6, 7, 8, 6, 6, 7, N'Nguyễn Văn An'),
('R003', '2025-09-15', 8, 8, 9, 7, 8, 8, 7, 7, 9, N'Nguyễn Văn An'),
('R004', '2025-09-18', 7, 6, 7, 6, 7, 7, 6, 5, 7, N'Nguyễn Văn An'),
('R005', '2025-09-20', 8, 7, 8, 7, 8, 8, 6, 6, 8, N'Nguyễn Văn An'),
('R006', '2025-09-23', 6, 7, 7, 6, 6, 7, 6, 5, 7, N'Nguyễn Văn An'),
('R007', '2025-09-25', 7, 8, 8, 7, 8, 8, 6, 7, 8, N'Nguyễn Văn An'),
('R008', '2025-09-27', 8, 7, 8, 7, 8, 9, 7, 7, 8, N'Nguyễn Văn An'),
('R009', '2025-09-29', 8, 8, 9, 8, 8, 9, 7, 8, 9, N'Nguyễn Văn An'),
('R010', '2025-09-30', 7, 7, 8, 7, 7, 8, 6, 6, 8, N'Nguyễn Văn An'),
('R011', '2025-09-10', 8, 8, 9, 8, 8, 9, 7, 7, 9, N'Phạm Thị Dung'),
('R012', '2025-09-12', 7, 8, 8, 7, 8, 8, 7, 7, 8, N'Phạm Thị Dung'),
('R013', '2025-09-14', 9, 9, 9, 8, 9, 9, 8, 8, 9, N'Phạm Thị Dung'),
('R014', '2025-09-17', 8, 8, 8, 7, 8, 8, 7, 7, 8, N'Phạm Thị Dung'),
('R015', '2025-09-19', 9, 8, 9, 8, 8, 9, 8, 8, 9, N'Phạm Thị Dung'),
('R016', '2025-09-22', 8, 9, 9, 8, 9, 9, 8, 8, 9, N'Phạm Thị Dung'),
('R017', '2025-09-25', 7, 7, 8, 7, 8, 8, 7, 7, 8, N'Phạm Thị Dung'),
('R018', '2025-09-27', 9, 9, 9, 8, 9, 9, 8, 8, 9, N'Phạm Thị Dung'),
('R019', '2025-09-29', 8, 8, 8, 7, 8, 8, 7, 7, 8, N'Phạm Thị Dung'),
('R020', '2025-10-01', 9, 8, 9, 8, 9, 9, 8, 8, 9, N'Phạm Thị Dung'),
('R021', '2025-09-08', 9, 9, 9, 9, 9, 10, 9, 9, 9, N'Lê Hồng Linh'),
('R022', '2025-09-12', 8, 8, 8, 8, 8, 9, 8, 8, 9, N'Lê Hồng Linh'),
('R023', '2025-09-15', 10, 9, 9, 9, 9, 10, 9, 9, 9, N'Lê Hồng Linh'),
('R024', '2025-09-18', 8, 8, 8, 8, 8, 8, 8, 8, 8, N'Lê Hồng Linh'),
('R025', '2025-09-20', 9, 9, 9, 8, 9, 9, 9, 9, 9, N'Lê Hồng Linh'),
('R026', '2025-09-22', 9, 9, 9, 9, 9, 10, 9, 9, 9, N'Lê Hồng Linh'),
('R027', '2025-09-25', 8, 8, 8, 8, 8, 8, 8, 8, 8, N'Lê Hồng Linh'),
('R028', '2025-09-27', 9, 9, 9, 9, 9, 9, 9, 9, 9, N'Lê Hồng Linh'),
('R029', '2025-09-29', 8, 8, 8, 8, 8, 8, 8, 8, 8, N'Lê Hồng Linh'),
('R030', '2025-10-01', 10, 10, 10, 9, 10, 10, 9, 9, 10, N'Lê Hồng Linh');
GO

INSERT INTO EquipmentStorage (EquipmentID, EquipmentName, EquipmentCategory, Quantity, PurchaseDate, Status, Description, StaffID)
VALUES
('EQ001', N'Giường đôi cao cấp', N'Nội thất', 20, '2024-02-01', N'Available', N'Giường gỗ sồi nhập khẩu, nệm cao su thiên nhiên', 'ST001'),
('EQ002', N'Tủ quần áo 3 cánh', N'Nội thất', 25, '2024-03-15', N'Available', N'Tủ gỗ công nghiệp phủ melamine chống ẩm', 'ST002'),
('EQ003', N'Bàn trang điểm', N'Nội thất', 15, '2024-01-20', N'Available', N'Bàn có gương và đèn LED tích hợp', 'ST003'),
('EQ004', N'Ghế sofa đôi', N'Nội thất', 12, '2023-12-10', N'In Use', N'Ghế đặt tại phòng Suite và Deluxe', 'ST004'),
('EQ005', N'Tivi Smart 43 inch', N'Điện tử', 30, '2024-04-05', N'Available', N'Tivi kết nối internet, có Netflix và YouTube', 'ST005'),
('EQ006', N'Máy lạnh Daikin', N'Điện tử', 20, '2023-11-25', N'Maintenance', N'Đang bảo trì định kỳ tháng 10', 'ST006'),
('EQ007', N'Tủ lạnh mini', N'Điện tử', 25, '2024-02-12', N'Available', N'Dung tích 90L, cho phòng Deluxe trở lên', 'ST002'),
('EQ008', N'Két sắt điện tử', N'Tiện ích', 18, '2024-03-01', N'Available', N'Dùng mã PIN, bảo mật cao', 'ST003'),
('EQ009', N'Máy sấy tóc', N'Tiện ích', 40, '2024-05-10', N'Available', N'Máy sấy công suất 1800W, có 2 chế độ nhiệt', 'ST001'),
('EQ010', N'Ấm đun nước siêu tốc', N'Tiện ích', 35, '2024-06-20', N'In Use', N'Ấm Inox, dung tích 1.5L', 'ST005');
GO
INSERT INTO RoomEquipment (RoomEquipmentID, RoomID, EquipmentStorage, Quantity, InstalledDate, Condition, Note, StaffID)
VALUES
('RE001', 'R001', 'EQ001', 1, '2024-03-10', N'Good', N'Giường đôi tiêu chuẩn', 'ST001'),
('RE002', 'R001', 'EQ005', 1, '2024-03-10', N'Good', N'Tivi Smart kết nối ổn định', 'ST005'),
('RE003', 'R002', 'EQ007', 1, '2024-03-15', N'Good', N'Tủ lạnh mini hoạt động tốt', 'ST002'),
('RE004', 'R003', 'EQ009', 1, '2024-04-05', N'Good', N'Máy sấy tóc mới', 'ST001'),
('RE005', 'R004', 'EQ010', 1, '2024-04-12', N'Good', N'Ấm đun nước mới thay', 'ST005'),
('RE006', 'R005', 'EQ002', 1, '2024-04-20', N'Good', N'Tủ quần áo đủ ngăn chứa', 'ST002'),
('RE007', 'R006', 'EQ001', 1, '2024-03-18', N'Good', N'Giường cao cấp', 'ST001'),
('RE008', 'R006', 'EQ005', 1, '2024-03-18', N'Good', N'Tivi Smart 43"', 'ST005'),
('RE009', 'R007', 'EQ003', 1, '2024-03-25', N'Good', N'Bàn trang điểm có đèn LED', 'ST003'),
('RE010', 'R008', 'EQ007', 1, '2024-03-30', N'Good', N'Tủ lạnh mini có đồ uống', 'ST002'),
('RE011', 'R009', 'EQ008', 1, '2024-04-02', N'Good', N'Két sắt điện tử trong tủ quần áo', 'ST003'),
('RE012', 'R010', 'EQ009', 1, '2024-04-10', N'Good', N'Máy sấy tóc Philips', 'ST001'),
('RE013', 'R011', 'EQ001', 1, '2024-02-05', N'Good', N'Giường lớn King Size', 'ST001'),
('RE014', 'R012', 'EQ004', 1, '2024-02-15', N'Good', N'Ghế sofa đôi da cao cấp', 'ST004'),
('RE015', 'R013', 'EQ005', 1, '2024-03-01', N'Good', N'Tivi Smart kết nối Netflix', 'ST005'),
('RE016', 'R014', 'EQ006', 1, '2024-03-12', N'Maintenance', N'Máy lạnh đang bảo dưỡng', 'ST006'),
('RE017', 'R015', 'EQ008', 1, '2024-03-22', N'Good', N'Két sắt điện tử an toàn', 'ST003'),
('RE018', 'R016', 'EQ001', 1, '2024-02-28', N'Good', N'Giường cao cấp nhập khẩu', 'ST001'),
('RE019', 'R017', 'EQ004', 1, '2024-03-03', N'Good', N'Sofa đôi đặt cạnh cửa sổ', 'ST004'),
('RE020', 'R018', 'EQ005', 1, '2024-03-08', N'Good', N'Tivi Smart 43" UHD', 'ST005'),
('RE021', 'R019', 'EQ008', 1, '2024-03-10', N'Good', N'Két sắt điện tử mã số riêng', 'ST003'),
('RE022', 'R020', 'EQ010', 1, '2024-03-15', N'Good', N'Ấm siêu tốc sang trọng', 'ST005');
GO
INSERT INTO FeeType (FeeTypeID, FeeTypeName, Category, DefaultPrice, Notes)
VALUES
('FT001', N'Check-in sớm',       N'Phụ Phí', 200000, N'Tính thêm nếu khách vào trước 12h trưa'),
('FT002', N'Check-out trễ',      N'Phụ Phí', 250000, N'Tính thêm nếu khách ra sau 14h'),
('FT003', N'Thêm giường phụ',    N'Phụ Phí', 300000, N'Thêm 1 giường gấp trong phòng'),
('FT004', N'Dịch vụ giặt ủi',    N'Phụ Phí', 80000,  N'Tính theo mỗi lần giặt ủi'),
('FT005', N'Hỏng TV',            N'Bồi Thường', 2500000, N'Bồi thường khi khách làm hư TV'),
('FT006', N'Hỏng máy lạnh',      N'Bồi Thường', 3500000, N'Sửa chữa hoặc thay mới máy lạnh'),
('FT007', N'Vỡ gương phòng tắm', N'Bồi Thường', 500000,  N'Tính phí khi gương bị vỡ'),
('FT008', N'Phí nâng cấp phòng', N'Khác', 400000, N'Khách yêu cầu nâng cấp từ Standard → Deluxe'),
('FT009', N'Phí mất thẻ phòng',  N'Khác', 150000, N'Mất thẻ từ hoặc chìa khóa phòng');
GO
INSERT INTO Booking (BookingID, CustomerID, RoomID, RentalType, CheckIn, CheckOut, Price, Status, StaffID)
VALUES
('BK001', 'CU001', 'R001', N'Day',  '2025-10-10 13:00', '2025-10-12 11:00', 500000,  N'CheckOut', 'ST001'),
('BK002', 'CU002', 'R002', N'Day',  '2025-10-13 14:00', '2025-10-14 12:00', 500000,  N'CheckOut', 'ST002'),
('BK003', 'CU003', 'R003', N'Day',  '2025-10-14 15:00', '2025-10-16 12:00', 800000,  N'CheckOut', 'ST003'),

-- các booking đang ở, sửa lại có CheckOut hợp lý
('BK004', 'CU004', 'R006', N'Day',  '2025-10-15 12:00', '2025-10-17 12:00', 1200000, N'CheckOut', 'ST004'),
('BK005', 'CU005', 'R007', N'Day',  '2025-10-15 13:00', '2025-10-16 11:00', 1200000, N'CheckOut', 'ST005'),

-- vẫn giữ những cái đang thuê nhưng thêm tạm enddate hôm sau để không NULL
('BK006', 'CU006', 'R010', N'Day',  '2025-10-14 14:00', '2025-10-15 12:00', 1500000, N'CheckOut', 'ST006'),
('BK007', 'CU007', 'R012', N'Hour', '2025-10-15 09:00', '2025-10-15 14:00', 150000,  N'CheckOut', 'ST002'),
('BK008', 'CU008', 'R013', N'Hour', '2025-10-15 10:00', '2025-10-15 13:00', 180000,  N'CheckOut', 'ST001'),
('BK009', 'CU009', 'R014', N'Hour', '2025-10-15 12:00', '2025-10-15 16:00', 180000,  N'CheckOut', 'ST003'),
('BK010', 'CU010', 'R015', N'Hour', '2025-10-15 08:00', '2025-10-15 11:00', 180000,  N'CheckOut', 'ST004');
GO

INSERT INTO BookingFee (BookingFeeID, BookingID, FeeTypeID, Quantity, Notes)
VALUES
('BF001', 'BK001', 'FT001', 1, N'Khách vào lúc 9h sáng – Check-in sớm'),
('BF002', 'BK002', 'FT002', 1, N'Khách trả phòng lúc 16h – Check-out trễ'),
('BF003', 'BK003', 'FT003', 1, N'Thêm giường phụ cho trẻ nhỏ'),
('BF004', 'BK004', 'FT004', 2, N'Khách gửi giặt 2 bộ quần áo'),
('BF005', 'BK005', 'FT005', 1, N'TV hỏng do rơi điều khiển'),
('BF006', 'BK006', 'FT006', 1, N'Máy lạnh không hoạt động sau khi khách rời phòng'),
('BF007', 'BK007', 'FT007', 1, N'Gương phòng tắm bị vỡ'),
('BF008', 'BK008', 'FT008', 1, N'Nâng cấp phòng từ Deluxe lên Suite'),
('BF009', 'BK009', 'FT009', 1, N'Mất thẻ phòng khi trả');
GO

INSERT INTO Service (ServiceID, ServiceName, Category, Price, Description)
VALUES
('SV001', N'Ăn sáng buffet',     N'Ăn uống',       150000, N'Buffet sáng phục vụ từ 6h - 9h'),
('SV002', N'Giặt ủi quần áo',    N'Giặt ủi',        50000,  N'Tính theo mỗi kg quần áo'),
('SV003', N'Đưa đón sân bay',    N'Vận chuyển',    300000, N'Đưa đón sân bay bằng xe riêng'),
('SV004', N'Massage thư giãn',   N'Spa',           400000, N'Massage toàn thân 60 phút'),
('SV005', N'Thuê xe máy',        N'Vận chuyển',    200000, N'Thuê xe máy theo ngày'),
('SV006', N'Gọi món tại phòng',  N'Ăn uống',       100000, N'Phục vụ đồ ăn tận phòng'),
('SV007', N'Sauna & xông hơi',   N'Spa',           250000, N'Trọn gói 45 phút'),
('SV008', N'Thuê phòng họp',     N'Dịch vụ khác',  800000, N'Phòng họp tối đa 20 người, có máy chiếu');
GO

INSERT INTO ServiceUsage (UsageID, BookingID, ServiceID, Quantity, StaffID)
VALUES
('SU001', 'BK001', 'SV001', 2, 'ST001'), -- Ăn sáng buffet
('SU002', 'BK001', 'SV002', 1, 'ST005'), -- Giặt ủi
('SU003', 'BK002', 'SV003', 1, 'ST002'), -- Đưa đón sân bay
('SU004', 'BK003', 'SV005', 2, 'ST004'), -- Thuê xe máy
('SU005', 'BK004', 'SV004', 1, 'ST006'), -- Massage thư giãn
('SU006', 'BK005', 'SV006', 3, 'ST001'); -- Gọi món tại phòng
GO
INSERT INTO Invoice (InvoiceID, BookingID, TotalAmount, PaymentMethod, PaidStatus, StaffID, Note)
VALUES
('IV001', 'BK001', 1350000, N'Tiền mặt', N'Paid', 'ST001', N'Tổng đúng theo dịch vụ + phụ phí + phòng'),
('IV002', 'BK002',  950000, N'Thẻ', N'Paid', 'ST004', N'Cập nhật lại đúng tổng'),
('IV003', 'BK003', 1500000, N'Tiền mặt', N'Unpaid', 'ST002', N'Tổng đúng theo dữ liệu'),
('IV004', 'BK004', 1560000, N'Chuyển khoản', N'Paid', 'ST005', N'Chưa Checkout, tạm tính phí'),
('IV005', 'BK005', 2800000, N'Thẻ', N'Paid', 'ST003', N'Bao gồm bồi thường TV + gọi món'),
('IV006', 'BK006', 3900000, N'Tiền mặt', N'Paid', 'ST006', N'Hỏng máy lạnh'),
('IV007', 'BK007',  500000, N'Tiền mặt', N'Paid', 'ST002', N'Gương bị vỡ, đã cộng phí'),
('IV008', 'BK008',  480000, N'Thẻ', N'Paid', 'ST001', N'Nâng cấp phòng Deluxe lên Suite'),
('IV009', 'BK009',  330000, N'Tiền mặt', N'Paid', 'ST003', N'Mất thẻ phòng'),
('IV010', 'BK010',  180000, N'Thẻ', N'Paid', 'ST004', N'Giờ thuê ngắn');
GO