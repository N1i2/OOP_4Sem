use laba8_OOP

drop table if exists Class
drop table if exists Images

go
Create table Class(
id int primary key,
name varchar(50),
semestr int check(semestr between 1 and 3),
years int check(years between 1 and 4),
count_of_labs int check(count_of_labs between 0 and 999),
count_of_lects int check(count_of_lects between 0 and 999),
control_type int check(control_type between 1 and 2)
)
Create table Images(
id int primary key, 
img varchar(100),
Foreign key (id) references Class(id))



go
declare @i int = 0;
while @i < 3
begin

insert Class(id, name, semestr, years, count_of_labs, count_of_lects, control_type) 
values(@i, 'nikola', 3, 4, 130, 90, 2);
set @i += 1;
end;


insert Images(id, img)
values(0, 'D:\univer\OOP\laba_8(-)\laba_8\image\1_car.jpg')

