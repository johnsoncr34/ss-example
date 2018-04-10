@cls
@echo.
@echo.
@echo Works:
curl -G --header "Accept: application/json" http://localhost:8080/v1/works/point/3

@echo.
@echo.
@echo.
@echo.
@echo Does not work:
curl -G --header "Accept: application/json" http://localhost:8080/v1/does/not/work/point/3

@echo.
@echo.
@echo.
@echo.
@echo Why does this work:
curl -G --header "Accept: application/json" http://localhost:8080/v1/why/does/this/work/point/3
