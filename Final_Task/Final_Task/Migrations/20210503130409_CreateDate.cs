using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_Task.Migrations
{
    public partial class CreateDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" insert into Genre (Title) values ('Rock')
            insert into Genre (Title) values ('Pop')
            insert into Genre (Title) values ('Dance Music')
	        insert into Genre (Title) values ('Classic')
	        insert into Genre (Title) values ('Rap')");
            migrationBuilder.Sql(@"insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('Eminem',CAST('1985-09-09' as date),'32233','eminem@gamil.com', 'eminem_official')
            insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('Poplavsiy',CAST('1966-02-09' as date),'32323','poplav@gamil.com', 'poplavskiy_official')
	        insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('Avici',CAST('1983-02-01' as date),'32233','avici@gamil.com', 'avici_official')
	        insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('Nirvana',CAST('1969-09-09' as date),'32233','nirvana@gamil.com', 'nirvana_official')
		    insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('Beethoven',CAST('1770-12-16' as date),'32233','press f', 'press f')
            insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('Arctic Monkeys',CAST('1977-02-01' as date),'32233','arcticmonkeys@gamil.com', 'ArcticMonkeyes_official')
	        insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('David Guetta',CAST('1984-09-09' as date),'32233','Guetta@gamil.com', 'Guetta_official')");
            migrationBuilder.Sql(@"insert into Song (Title,Duration,RealesDate,GenreId) values ('Lose your self',Cast('00:03:19' as time),GETDATE(),(select GenreId from Genre where Title ='Rap'))
            insert into Song (Title,Duration,RealesDate,GenreId) values ('Salo',Cast('00:02:19' as time),GETDATE(),(select GenreId from Genre where Title ='Dance Music'))
	        insert into Song (Title,Duration,RealesDate,GenreId) values ('Wake me up',Cast('00:04:19' as time),CAST('2005-04-19' as date),(select GenreId from Genre where Title ='Pop'))
	        insert into Song (Title,Duration,RealesDate,GenreId) values ('Smells like teen Spirit',Cast('00:02:40' as time),CAST('1999-09-09' as date),(select GenreId from Genre where Title ='Classic'))
		    insert into Song (Title,Duration,RealesDate,GenreId) values ('Some Song',Cast('00:03:05' as time),CAST('1805-09-09' as date),(select GenreId from Genre where Title ='Rock'))
            insert into Song (Title,Duration,RealesDate,GenreId) values ('Do i wanna know',Cast('00:04:19' as time),CAST('2010-04-19' as date),(select GenreId from Genre where Title ='Rock'))
	        insert into Song (Title,Duration,RealesDate,GenreId) values ('Titanium',Cast('00:02:40' as time),CAST('1995-09-09' as date),(select GenreId from Genre where Title ='Dance Music'))");
            migrationBuilder.Sql(@"insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='Avici'),(select SongId from Song where Title ='Wake me up'))
            insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='Nirvana'),(select SongId from Song where Title ='Smells like teen Spirit'))
            insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='Poplavsiy'),(select SongId from Song where Title ='Salo'))
            insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='Eminem'),(select SongId from Song where Title ='Lose your self'))
            insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='Beethoven'),(select SongId from Song where Title ='Some Song'))
            insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='Arctic Monkeys'),(select SongId from Song where Title ='Do i wanna know'))
            insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='David Guetta'),(select SongId from Song where Title ='Titanium'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" insert into Genre (Title) values ('Rock')
            insert into Genre (Title) values ('Pop')
            insert into Genre (Title) values ('Dance Music')
	        insert into Genre (Title) values ('Classic')
	        insert into Genre (Title) values ('Rap')");
            migrationBuilder.Sql(@"insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('Eminem',CAST('1985-09-09' as date),'32233','eminem@gamil.com', 'eminem_official')
            insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('Poplavsiy',CAST('1966-02-09' as date),'32323','poplav@gamil.com', 'poplavskiy_official')
	        insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('Avici',CAST('1983-02-01' as date),'32233','avici@gamil.com', 'avici_official')
	        insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('Nirvana',CAST('1969-09-09' as date),'32233','nirvana@gamil.com', 'nirvana_official')
		    insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('Beethoven',CAST('1770-12-16' as date),'32233','press f', 'press f')
            insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('Arctic Monkeys',CAST('1977-02-01' as date),'32233','arcticmonkeys@gamil.com', 'ArcticMonkeyes_official')
	        insert into Artist (Name,DateofBirth,Phone,Email,InstagramUrl) values ('David Guetta',CAST('1984-09-09' as date),'32233','Guetta@gamil.com', 'Guetta_official')");
            migrationBuilder.Sql(@"insert into Song (Title,Duration,RealesDate,GenreId) values ('Lose your self',Cast('00:03:19' as time),GETDATE(),(select GenreId from Genre where Title ='Rap'))
            insert into Song (Title,Duration,RealesDate,GenreId) values ('Salo',Cast('00:02:19' as time),GETDATE(),(select GenreId from Genre where Title ='Dance Music'))
	        insert into Song (Title,Duration,RealesDate,GenreId) values ('Wake me up',Cast('00:04:19' as time),CAST('2005-04-19' as date),(select GenreId from Genre where Title ='Pop'))
	        insert into Song (Title,Duration,RealesDate,GenreId) values ('Smells like teen Spirit',Cast('00:02:40' as time),CAST('1999-09-09' as date),(select GenreId from Genre where Title ='Classic'))
		    insert into Song (Title,Duration,RealesDate,GenreId) values ('Some Song',Cast('00:03:05' as time),CAST('1805-09-09' as date),(select GenreId from Genre where Title ='Rock'))
            insert into Song (Title,Duration,RealesDate,GenreId) values ('Do i wanna know',Cast('00:04:19' as time),CAST('2010-04-19' as date),(select GenreId from Genre where Title ='Rock'))
	        insert into Song (Title,Duration,RealesDate,GenreId) values ('Titanium',Cast('00:02:40' as time),CAST('1995-09-09' as date),(select GenreId from Genre where Title ='Dance Music'))");
            migrationBuilder.Sql(@"insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='Avici'),(select SongId from Song where Title ='Wake me up'))
            insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='Nirvana'),(select SongId from Song where Title ='Smells like teen Spirit'))
            insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='Poplavsiy'),(select SongId from Song where Title ='Salo'))
            insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='Eminem'),(select SongId from Song where Title ='Lose your self'))
            insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='Beethoven'),(select SongId from Song where Title ='Some Song'))
            insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='Arctic Monkeys'),(select SongId from Song where Title ='Do i wanna know'))
            insert into SongArtist (ArtistId,SongId) values ((select ArtistId from Artist where Name ='David Guetta'),(select SongId from Song where Title ='Titanium'))");
        }
    }
}
