{-# LANGUAGE CPP #-}
{-# LANGUAGE NoRebindableSyntax #-}
{-# OPTIONS_GHC -fno-warn-missing-import-lists #-}
module Paths_TestProject (
    version,
    getBinDir, getLibDir, getDynLibDir, getDataDir, getLibexecDir,
    getDataFileName, getSysconfDir
  ) where

import qualified Control.Exception as Exception
import Data.Version (Version(..))
import System.Environment (getEnv)
import Prelude

#if defined(VERSION_base)

#if MIN_VERSION_base(4,0,0)
catchIO :: IO a -> (Exception.IOException -> IO a) -> IO a
#else
catchIO :: IO a -> (Exception.Exception -> IO a) -> IO a
#endif

#else
catchIO :: IO a -> (Exception.IOException -> IO a) -> IO a
#endif
catchIO = Exception.catch

version :: Version
version = Version [0,1,0,0] []
bindir, libdir, dynlibdir, datadir, libexecdir, sysconfdir :: FilePath

bindir     = "C:\\Users\\Daniel\\source\\repos\\HaskellProjects\\TestProject\\.stack-work\\install\\6722f90c\\bin"
libdir     = "C:\\Users\\Daniel\\source\\repos\\HaskellProjects\\TestProject\\.stack-work\\install\\6722f90c\\lib\\x86_64-windows-ghc-8.8.4\\TestProject-0.1.0.0-7CYPMtVmMgY1AJbYL5Oy9K-TestProject-exe"
dynlibdir  = "C:\\Users\\Daniel\\source\\repos\\HaskellProjects\\TestProject\\.stack-work\\install\\6722f90c\\lib\\x86_64-windows-ghc-8.8.4"
datadir    = "C:\\Users\\Daniel\\source\\repos\\HaskellProjects\\TestProject\\.stack-work\\install\\6722f90c\\share\\x86_64-windows-ghc-8.8.4\\TestProject-0.1.0.0"
libexecdir = "C:\\Users\\Daniel\\source\\repos\\HaskellProjects\\TestProject\\.stack-work\\install\\6722f90c\\libexec\\x86_64-windows-ghc-8.8.4\\TestProject-0.1.0.0"
sysconfdir = "C:\\Users\\Daniel\\source\\repos\\HaskellProjects\\TestProject\\.stack-work\\install\\6722f90c\\etc"

getBinDir, getLibDir, getDynLibDir, getDataDir, getLibexecDir, getSysconfDir :: IO FilePath
getBinDir = catchIO (getEnv "TestProject_bindir") (\_ -> return bindir)
getLibDir = catchIO (getEnv "TestProject_libdir") (\_ -> return libdir)
getDynLibDir = catchIO (getEnv "TestProject_dynlibdir") (\_ -> return dynlibdir)
getDataDir = catchIO (getEnv "TestProject_datadir") (\_ -> return datadir)
getLibexecDir = catchIO (getEnv "TestProject_libexecdir") (\_ -> return libexecdir)
getSysconfDir = catchIO (getEnv "TestProject_sysconfdir") (\_ -> return sysconfdir)

getDataFileName :: FilePath -> IO FilePath
getDataFileName name = do
  dir <- getDataDir
  return (dir ++ "\\" ++ name)
