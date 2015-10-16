USE [master]
GO
/****** Object:  Database [�uflo]    Script Date: 15/10/2015 08:12:44 p.m. ******/
CREATE DATABASE [�uflo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'�uflo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER2012\MSSQL\DATA\�uflo.mdf' , SIZE = 17408KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'�uflo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER2012\MSSQL\DATA\�uflo_log.ldf' , SIZE = 92864KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [�uflo] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [�uflo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [�uflo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [�uflo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [�uflo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [�uflo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [�uflo] SET ARITHABORT OFF 
GO
ALTER DATABASE [�uflo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [�uflo] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [�uflo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [�uflo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [�uflo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [�uflo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [�uflo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [�uflo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [�uflo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [�uflo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [�uflo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [�uflo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [�uflo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [�uflo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [�uflo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [�uflo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [�uflo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [�uflo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [�uflo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [�uflo] SET  MULTI_USER 
GO
ALTER DATABASE [�uflo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [�uflo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [�uflo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [�uflo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

USE [�uflo]
GO
/****** Object:  Schema [gd_�uflo]    Script Date: 15/10/2015 08:12:44 p.m. ******/
CREATE SCHEMA [gd_�uflo]
GO

USE [master]
GO
ALTER DATABASE [�uflo] SET  READ_WRITE 
GO