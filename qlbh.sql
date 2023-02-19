USE [master]
GO

/****** Object:  Database [QLBH]    Script Date: 19/02/2023 8:37:46 SA ******/
CREATE DATABASE [QLBH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLBH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLBH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [QLBH] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [QLBH] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [QLBH] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [QLBH] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [QLBH] SET ARITHABORT OFF 
GO

ALTER DATABASE [QLBH] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [QLBH] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [QLBH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [QLBH] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [QLBH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [QLBH] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [QLBH] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [QLBH] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [QLBH] SET  DISABLE_BROKER 
GO

ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [QLBH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [QLBH] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [QLBH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [QLBH] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [QLBH] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [QLBH] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [QLBH] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [QLBH] SET  MULTI_USER 
GO

ALTER DATABASE [QLBH] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [QLBH] SET DB_CHAINING OFF 
GO

ALTER DATABASE [QLBH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [QLBH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [QLBH] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [QLBH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [QLBH] SET QUERY_STORE = ON
GO

ALTER DATABASE [QLBH] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [QLBH] SET  READ_WRITE 
GO
