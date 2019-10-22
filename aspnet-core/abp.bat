@setlocal enableextensions enabledelayedexpansion
@echo off

goto :init

:header
    echo %__NAME% v%__VERSION%
    echo This is a sample batch file template,
    echo providing command-line arguments and flags.
    echo.
    goto :eof

:usage
    echo USAGE:
    echo   %__BAT_NAME% [flags] "required argument" "optional argument" 
    echo.
    echo.  /?, --help           shows this help
    echo.  /v, --version        shows the version
    echo.  /e, --verbose        shows detailed output
    echo.  -f, --flag value     specifies a named parameter value
    goto :eof

:version
    if "%~1"=="full" call :header & goto :eof
    echo %__VERSION%
    goto :eof

:missing_argument
    call :header
    call :usage
    echo.
    echo ****                                   ****
    echo ****    MISSING "REQUIRED ARGUMENT"    ****
    echo ****                                   ****
    echo.
    goto :eof

:init
    set "__NAME=%~n0"
    set "__VERSION=1.23"
    set "__YEAR=2017"

    set "__BAT_FILE=%~0"
    set "__BAT_PATH=%~dp0"
    set "__BAT_NAME=%~nx0"
	
	set "ApplicationPath=%__BAT_PATH%src\NEXARC.Application\"
	set "tab=    "
	set "auth="
	set "dir="
	set "folder="
	set "name="		
	set "path="
	
    set "OptHelp="
    set "OptVersion="
    set "OptVerbose="

    set "ActionParameter="
    set "NameParameter="
	set "OptionalParameter="
    set "NamedFlag="

:parse
    if "%~1"=="" goto :validate

    if /i "%~1"=="/?"         call :header & call :usage "%~2" & goto :end
    if /i "%~1"=="-?"         call :header & call :usage "%~2" & goto :end
    if /i "%~1"=="--help"     call :header & call :usage "%~2" & goto :end

    if /i "%~1"=="/v"         call :version      & goto :end
    if /i "%~1"=="-v"         call :version      & goto :end
    if /i "%~1"=="--version"  call :version full & goto :end

    if /i "%~1"=="/e"         set "OptVerbose=yes"  & shift & goto :parse
    if /i "%~1"=="-e"         set "OptVerbose=yes"  & shift & goto :parse
    if /i "%~1"=="--verbose"  set "OptVerbose=yes"  & shift & goto :parse

    if /i "%~1"=="--flag"     set "NamedFlag=%~2"   & shift & shift & goto :parse

    if not defined ActionParameter     set "ActionParameter=%~1"     & shift & goto :parse
    if not defined NameParameter  set "NameParameter=%~1"  & shift & goto :parse
    if not defined OptionalParameter  set "OptionalParameter=%~1"  & shift & goto :parse	

    shift
    goto :parse

:validate
    if not defined ActionParameter call :missing_argument & goto :end


:main
    if defined OptVerbose (
        echo **** DEBUG IS ON
    )
	
	if "%ActionParameter%" == "generate-crud" (

		IF DEFINED NameParameter ( 
			


			goto :generate-crud
			EXIT /B %ERRORLEVEL%;
			
		) ELSE ( 
			echo "Missing second parameter." 
			exit /B 
		)

	) else (
		ECHO "Undefined Argument";
		EXIT /B %ERRORLEVEL%
	)
	


:end
    call :cleanup
    exit /B

:cleanup
    REM The cleanup function is only really necessary if you
    REM are _not_ using SETLOCAL.
    set "__NAME="
    set "__VERSION="
    set "__YEAR="

    set "__BAT_FILE="
    set "__BAT_PATH="
    set "__BAT_NAME="

    set "OptHelp="
    set "OptVersion="
    set "OptVerbose="

    set "ActionParameter="
    set "ActionParameter2="
    set "NamedFlag="

    goto :eof
	
:generate-crud

	set "GenerationPath=%ApplicationPath%%NameParameter%";
	For %%A in ("%GenerationPath%") do (
		set "path=%%~fA"
		set "dir=%%~fA\Nex%%~nA"
		set "folder=%%~fA\Nex%%~nA"
		set "name=%%~nA"
		echo %%~fA
		);


	rem echo %path%
	rem echo %dir%
	rem echo %folder%
	rem echo %name%

	rem pause

	for /f "delims=" %%a in ('dir /s /b %name%.cs') do (
		set "found=%%a"
	);


	for /f "delims=" %%b in ('findstr /e /c:"{ get; set; }" "%found%"') do (
		set "data=%%b"
	)
	
	if %ERRORLEVEL% neq 0 set "data=^/^/Failed to parse Entity."
	
	mkdir %path%;
	mkdir %path%\Dto;

	REM AppService File
	(
		echo using Abp.Application.Services;
		echo using Abp.Application.Services.Dto;
		echo using Abp.Authorization;
		echo using NEXARC.Authorization;
		echo using Abp.Collections.Extensions;
		echo using Abp.Domain.Repositories;
		echo using Abp.Extensions;
		echo using NEXARC.Nex%name%.Dto;
		echo using System;
		echo using System.Collections.Generic;
		echo using System.Linq;
		echo using System.Text;
		echo using System.Threading.Tasks;
		echo.				
		echo namespace NEXARC.Nex%name%
		echo {
		if "%OptionalParameter%"=="auth" (
			echo %tab%^[AbpAuthorize^(PermissionNames.Pages_%name%Auth^)^]
		)
		echo %tab%public class %name%AppService : AsyncCrudAppService^<%name%, %name%Dto, int, Paged%name%ResultRequestDto, Create%name%Dto, Update%name%Dto^>, I%name%AppService
		echo %tab%{
		echo %tab%%tab%private readonly IRepository^<%name%^> _r%name%;
		echo %tab%%tab%public %name%AppService^(IRepository^<%name%^> r%name%^) : base^(r%name%^)
		echo %tab%%tab%{
		echo %tab%%tab%%tab%_r%name% = r%name%;
		echo %tab%%tab%}
		echo.
		echo %tab%%tab%protected override IQueryable^<%name%^> CreateFilteredQuery^(Paged%name%ResultRequestDto input^)			
		echo %tab%%tab%{
		echo %tab%%tab%%tab%return Repository.GetAll^(^)
		echo %tab%%tab%%tab%%tab%^/^/.WhereIf^(^!input.Keyword.IsNullOrWhiteSpace^(^), x ^=^> x.Name.Contains^(input.Keyword^)^)
		echo %tab%%tab%%tab%%tab%^/^/.WhereIf^(input.Status.HasValue, x ^=^> x.Status == input.Status^)
		echo %tab%%tab%%tab%%tab%.AsQueryable^(^);
		echo %tab%%tab%}
		echo.
		echo %tab%}
		echo }
	  
	) > %path%\%name%AppService.cs
				
	
	REM AppService Interface File			
	(
		echo using Abp.Application.Services;
		echo using NEXARC.Nex%name%.Dto;
		echo using System;
		echo using System.Collections.Generic;
		echo using System.Linq;
		echo using System.Text;
		echo using System.Threading.Tasks;
		echo.				
		echo namespace NEXARC.Nex%name%
		echo {
		echo %tab%public interface I%name%AppService : IAsyncCrudAppService^<%name%Dto, int, Paged%name%ResultRequestDto, Create%name%Dto, Update%name%Dto^>
		echo %tab%{
		echo.
		echo %tab%%tab%^/^/Put something here if applicable
		echo.
		echo %tab%}
		echo }
	  
	) > %path%\I%name%AppService.cs


	REM Entity Dto File			
	(
		echo using Abp.Application.Services;
		echo using Abp.AutoMapper;
		echo using Abp.Application.Services.Dto;
		echo using System;
		echo.				
		echo namespace NEXARC.Nex%name%.Dto
		echo {
		echo %tab%^[AutoMapFrom^(typeof^(%name%^)^)^]
		echo %tab%public class %name%Dto ^: EntityDto^<int^>
		echo %tab%{
		echo.
		echo %tab%%tab%^/^/Entity fields here
		echo.
		echo %tab%}
		echo }
	  
	) > %path%\Dto\%name%Dto.cs

	REM Create Entity Dto File			
	(
		echo using Abp.AutoMapper;
		echo using System;
		echo using System.ComponentModel.DataAnnotations;
		echo.				
		echo namespace NEXARC.Nex%name%.Dto
		echo {
		echo %tab%^[AutoMapTo^(typeof^(%name%^)^)^]
		echo %tab%public class Create%name%Dto
		echo %tab%{
		echo.
		echo %tab%%tab%^/^/Entity fields here with data annotation
		echo.
		echo %tab%}
		echo }
	  
	) > %path%\Dto\Create%name%Dto.cs

	REM Update Entity Dto File			
	(
		echo using Abp.Application.Services.Dto;
		echo.				
		echo namespace NEXARC.Nex%name%.Dto
		echo {
		echo %tab%public class Update%name%Dto ^: Create%name%Dto, IEntityDto
		echo %tab%{
		echo.
		echo %tab%%tab%public int Id ^{ get; set; ^}
		echo.
		echo %tab%}
		echo }
	  
	) > %path%\Dto\Update%name%Dto.cs


	REM Paged Entity Dto File			
	(
		echo using Abp.Application.Services.Dto;
		echo.				
		echo namespace NEXARC.Nex%name%.Dto
		echo {
		echo %tab%public class Paged%name%ResultRequestDto ^: PagedResultRequestDto
		echo %tab%{
		echo.
		echo %tab%%tab%public string Keyword ^{ get; set; ^}
		echo %tab%%tab%public RecordStatus? Status ^{ get; set; ^}
		echo.
		echo %tab%}
		echo }
	  
	) > %path%\Dto\Paged%name%ResultRequestDto.cs


	REM echo full path: %%~fA
	REM echo directory: %%~dA
	REM echo path: %%~pA
	REM echo file name only: %%~nA
	REM echo extension only: %%~xA
	REM echo expanded path with short names: %%~sA
	REM echo attributes: %%~aA
	REM echo date and time: %%~tA
	REM echo size: %%~zA
	REM echo drive + path: %%~dpA
	REM echo name.ext: %%~nxA
	REM echo full path + short name: %%~fsA)



	goto :end	
	
