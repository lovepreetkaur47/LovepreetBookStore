2023/10/23
3:41
1 create a Mvc project for assignment 2 by name of LovepreetBookStore
then 
open my github 
create a public repositary same a project name
push my project 
3.43
add a new file README.txt
and commit
new i am going to test it in college i comment the ssl 
27/10/2023
10.45
examine all code in visiual studio 
and also know about how beakpoint 
at idex and privacy 
then run it 
and hit continue 
sooooooo
it show welcome massage page
then i click on privacy 
it runs back to visual studio 
then i hit continue 
i can see privacy 
then i took a break 
11.20am
i return back and 
i fogot to register them i tried to resister
but i was  doing login 
it return in valid password 
then i register and set password
it shows exception 
and its because of i have not applied migration 
then i applied migration from brower
...
../
/
/
now iam tring to login my resiter account
let's go
11.26
 first i was unable because of breake points 
 then i remove and test it 
 its good to go
yup 
i did it......
now its time to do 1.3 bootstrap
I CHOOSE FLATY THEME AND DOWNLOAD BOOTSTRAP.CSS
then.....
i took break and enjoy the outside view 
then return to work
1:09 pm
i clone repo on my own computer 
remove comment from ssl
the run it
it was good to go ahead
rename exiting site.css file and add new site.css which is provided by Andrew
modify layout.css and also 
rename the bootstrap and add new bootstrap add to layout.cshtml 
1:33pm and also
//
/
modify layoutpartial.css
then run it 
yupppp......
 i did it 
 i did not understand the next i took a break
after long break
10.21am 
28/10/2023
first i added contentMangemet in navigation bar
then i did
alot of struggle to add drop down item 
after long search i add it i took little bit help from youtube 
actually i a following a channel coding ninja where i found this method
first i changed nav-item to class="nav-item dropdown
this is css style
then 
<a> modify toggles the dropdown menu
class="nav-link dropdown-toggle" classes the styling of the link,  function as a dropdown toggle.
href="#": The href attribute is set to # to make the link clickable but not direct to any actual page.

placeceholder href attributes, usually for JavaScript-enabled functionality. Replace # with actual URLs as needed.
same day
evening
6.06
i started work again on my assignment afetr setting up the phpstrom for assignment 
i test it again 
i can,t believe on my eyes 
its working without any mistake
now......................................
i am going to satrt 1.4 part
at 6.08
first create 3 more project as previous one
upssssssssssssssssssss.......
i created wrong one as previous mvc
now i delete all create project 
then search for claass library i found it 
i create its on another name 
them also delete
4.00 23/10/2023
i found right one now i am going to create it with class library
and insatall two commands 
but i was unable.......
then i create first project LvepreetBook.DataAccess
them addd Data folder to it And 
then install relational comand
then i delete migration folder

and insatall command
then sqlserver
again i did same thing for Mondel and utility
them i copied Model folder to LovepreetBook.models
And i got three error 
thn i read definition and solve it them
them i provide rference
now i am ready to go forward
5.30 create static class in LovepreetBook.Utility project
then modify the properties of sd class to public
then 
5.37 going to add Project references to Main project
also add roject references to DataAccess project 
5.52
I add new mvc area By name Customer
first i was enable them i remove error add it again
6.12 
i changed routes in satrtup file to customr
then i moved homeController.cs to area- customer- controler
and delete model,Data folder
Edit homecontroller [Area("Customer")]
them rum it it gave me masssage local host is not found 
uppppppppppppppppppppp.............................................
then i add pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}"); to satrtup file 
and run it 
yupppppppppppp it wil work
30/10/2023
9.47
i startrd again 
and test it it worked proper
but bootstrap and css is not working
then i followed toturial slides again 
copied _viewImports.cshtml and _viewStart.cshtml to Cutomer area and
Changed path in _ViewStart.cshtml 
And then test it
yupppppppppppppppppppppp
its working
and New mvc Admin area to area and delete Data Model Folder
10.06
Delete the Controller from Area Folder
Finally
I cant believe its Completed 
yuuup
Lets dance ......................
At last i edit dropdown menu
references:
https://getbootstrap.com/docs/4.4/components/dropdowns/
then edit in to 
Man Love preet
5/11/2023
i start project again 
12.40
i build project 
yupppppp......................................
it run 
and 
good to go ahead
12.41
i run command AddDefualtMigration 
first i tried it at LovepreetBookStore
as folow toturial 
i run it in side LovepreetBook.DataAccess project i
it succed
1.01pm 
run update-database command
yuppp 
it run succed
then after some time it run Add-migration AddCategory file but it was first time successful 
second i add calass category.cs
bthen update aaaaa applicationDbCotext.cs 
then again run Categories migrataion file 
after analysing i solve tehe problem get data in migration file.
2.58 i run update-Database commmand finally i did it 

finaaly its time to go ahead 
and i am at 2.2 repositary

add folder name as Repository in .DataAccess 
and by Repository folder add IRepository folder under folder add 
item namedby IRepository.cs

 modifing file to do through all crud operations...........

3.05
Add new class Repository.cs in Repository folder
then 
i add  use statement and potential fixes to remove errors
after
Modify create the constructors 

3.30
i add an indivdual repos for category named CategoryRepository.cs 
and ICategoryRepository.cs 
modify CategoryRepository.cs
while fixing i got errors and solve them using potential errors like adding name spaces
also using statements

4.03
add interface folder named by ISP_Call.cs 
which extends IDisposable
then 
i install the NuGet Package for 'Dapper' as shown in potential fixing eroor solution
then i add it in using statement


4.15
add class sp_call.cs in Repository folder
implementing ISP_Call.cs interface
then i add database connection

8.12
updating  ISP_Call.cs interface

then i got a email in my inbox tomorrow class is cancel
and i left my all assignment and take breake

8/11/2023
11.23
add interface class name IUnitOfWork.cs in IRepository folder 
and update it as shown in pptx
after............
i add UnitOfWork.cs class in Repository 

and services in startup.cs 
its time to satrt

********************* part 2.3
12.1
create a CategoryController in Areas-Admin-Controller 
and update.................

then
add index view html file in Areas-View a
modify with code which is provided Assignment2- files folder( Category Index View.txt.....)
then link it in layout page
run the app
is good to go


12.30
add the icons in the Category through Font Awesome 4
and confirm by run the appliction
in wwwroot-js folder name as category.js
add @section call to the category.js 


12.45
appling activate  'Edit' and 'Delete' buttons and 
using the Upsert action....
copy and paste the code from Category Upsert View.txt 
after
create partial
_CreateAndBackToListButton.cshtml file 
in View-Shared fold
 _EditAndBookToListButton and add @model razor statement 

1.00
i update Upsert.cshtml 
then run application
added @section call to Scripts in Upsert.cshtml file


at last------------------
i added the API to call for HTTPDelete in the CategoryController
delete funtion in category with including the onclick 
I completed  part2 
but create button not working...........

