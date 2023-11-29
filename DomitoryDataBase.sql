DROP TABLE IF EXISTS students, campus, dm5_rooms CASCADE;
CREATE TABLE students(
	std_name text,
	dormitory_number text,
	room text,
	treaty text,
	contractual_effect text,
	faculty text,
	f_group text,
	remarks text,
	declaration text);

INSERT INTO students(std_name, dormitory_number, room, treaty, contractual_effect, faculty, f_group, remarks, declaration)
VALUES ('Truneva Alina Dmitrievna', '5', '110Б', 'ОУ-0029011', '31.08.2024', 'ФИТ', '23216', '-', '-'),
	   ('Ivanova Elena Petrovna', '5', '110Б', 'ОУ-0029012', '30.08.2025', 'ФИТ', '23217', '-', '-'),
       ('Petrov Sergei Alexandrovich', '4', '23', 'ОУ-0029013', '29.08.2023', 'ЭФ', '23218', '-', '-'),
       ('Sidorova Maria Ivanovna', '5', '110М', 'ОУ-0029014', '28.08.2026', 'ФИТ', '23219', '-', '-');

	   
CREATE TABLE campus(domitory_number text);

INSERT INTO campus(domitory_number)
VALUES('1A'), ('1B'), ('4'), ('5'), ('6'), ('7'), ('8/1'), ('8/2'), ('9'), ('10');


CREATE TABLE dm5_rooms (room_number text);
INSERT INTO dm5_rooms(room_number)
VALUES('110Б'), ('110М'), ('111Б'), ('111М'), ('112М'), ('112Б');