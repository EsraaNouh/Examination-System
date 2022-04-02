

<h1> 
  ExaminationsystemV1
  </h1>
  
<p align="center">
 <img width="700" src="https://github.com/EsraaNouh/examinationsystemV1/blob/master/ScornfulIllfatedBobolink-size_restricted.gif">
</p>

## Entity relationship diagram (ERD)

<p align="center">
 <img width="1000" src="https://github.com/EsraaNouh/examinationsystemV1/blob/master/Untitled%20Diagram-ERD.drawio.png">
</p>

## Tech Stacks
* Entity frameWork
* SQL 
* .net
* SSRS (Reporting Services)
* OOP


--------------------

# Pysical tables 

 <img width="1000" src="https://github.com/EsraaNouh/examinationsystemV1/blob/master/pysical%20table.png">
--------------------

## Referential integrity constraints of System 
```
* course
├── course id 
│   └── course -- coiches
│     ├── delete null
│     └── update cascade 
│   └── course -- student course 
│     ├── delete cascade 
│     └── update cascade
│   └── course -- Question
│     ├── delete No action 
│     └── update cascade 
│   └── course -- ins_courses
│     ├── delete cascade 
│     └── update cascade 
│   └── course -- track_cources 
│     ├── delete cascade 
│     └── update cascade 
│   └── course -- topic
│     ├── delete cascade 
│     └── update cascade 


* Exam
├── Exam_id
│   └── Exam -- Stu_Exam
│     ├── delete no Action
│     └── update no Action
│   └── Exam -- Question_Exam
│     ├── delete cascade 
│     └── update cascade

* instructor 
├── ins id 
│   └── instructor -- track 
│     ├── delete null 
│     └── update cascade 
│   └── instructor -- Exam
│     ├── delete no action 
│     └── update cascade
│   └── instructor -- courses
│     ├── delete cascade 
│     └── update cascade

* Question  
├── Q_id 
│   └── Question -- stu Exam 
│     ├── delete no Action
│     └── update cascade 
│   └── Question--choice 
│     ├── delete cascade
│     └── update cascade
│   └── Question -- exam_Q
│     ├── update no actiom
│     └── update no actiom

* Student  
├── stu_id 
│   └──Stud_Stud
│     ├── delete no Action
│     └── update no action
│   └── student --Exam_stu
│     ├── delete cascade
│     └── update cascade
│   └── student -- stu_courses
│     ├── delete cascade
│     └── update cascade

* Track  
├── track_id 
│   └──Track -- student 
│     ├── delete cascade
│     └── update cascade
│   └── Track -- trackCourses
│     ├── delete cascade
│     └── update cascade



```
--------------------
## The Dictionary of Our Database 
| Schema Name | Table Name       | Column Name      | Data Type | Data Type ext  | Nullable | Primary Key | Foreign Key | Unique Key | Column  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  Description                                                                                                                                    |
| ----------- | ---------------- | ---------------- | --------- | -------------- | -------- | ----------- | ----------- | ---------- | -------------------------------------------------------------------------------------------------------- |
| dbo         | Choice           | C\_ID            | varchar   | varchar(5)     | N        | PK          |             |            | First part of the primary key of the table describes the Choice Letter(A, B, C or D)                     |
| dbo         | Choice           | Choice\_Text     | varchar   | varchar(100)   | N        |             |             |            | Choice itself                                                                                            |
| dbo         | Choice           | Q\_ID            | int       | int            | N        | PK          | FK          |            | Second part of the primary key of the table describes the ID of the question that contains these choices |
| dbo         | Course           | Course\_Id       | int       | int            | N        | PK          |             |            | Primary key of the table                                                                                 |
| dbo         | Course           | Course\_Name     | varchar   | varchar(20)    | N        |             |             |            | Course name                                                                                              |
| dbo         | Exam             | Course\_Id       | int       | int            | Y        |             | FK          |            | ID of the course, on which the exam is based                                                             |
| dbo         | Exam             | Date             | date      | date           | Y        |             |             |            | A specific day, in which this exam is available for students to take                                     |
| dbo         | Exam             | E\_Duration      | int       | int            | Y        |             |             |            | Duration that the student would take to answer the exam                                                  |
| dbo         | Exam             | E\_ID            | int       | int            | N        | PK          |             |            | Primary key of the table                                                                                 |
| dbo         | Exam             | Ins\_ID          | int       | int            | N        |             | FK          |            | ID of the instructor who created this exam                                                               |
| dbo         | Exam             | Start\_Time      | time      | time(7)        | Y        |             |             |            | A time starting from which the exam is available for students to take until the duration ends            |
| dbo         | Exam\_Questions  | E\_ID            | int       | int            | N        | PK          | FK          |            | ID of a created exam                                                                                     |
| dbo         | Exam\_Questions  | Q\_ID            | int       | int            | N        | PK          | FK          |            | Id of a specific question included in the created exam                                                   |
| dbo         | Ins\_Courses     | Course\_Id       | int       | int            | N        | PK          | FK          |            | ID of a course that is being taught by a specific instructor                                             |
| dbo         | Ins\_Courses     | Ins\_ID          | int       | int            | N        | PK          | FK          |            | ID of an instructor who teaches a specific bunch of courses                                              |
| dbo         | Instructor       | Ins\_Email       | varchar   | varchar(100)   | Y        |             |             | UK         | Instructor email that is used to get contact with him                                                    |
| dbo         | Instructor       | Ins\_ID          | int       | int            | N        | PK          |             |            | Primary key of the table                                                                                 |
| dbo         | Instructor       | Ins\_Name        | varchar   | varchar(50)    | N        |             |             |            | Instructor full name                                                                                     |
| dbo         | Instructor       | Ins\_Password    | varchar   | varchar(250)   | Y        |             |             |            | Instructor passowrd that validates his identity to login to the examination system as "Instructor"       |
| dbo         | Instructor       | Ins\_UserName    | varchar   | varchar(50)    | Y        |             |             | UK         | Instructor username that he uses to login to the examination system and create exams                     |
| dbo         | Question         | Course\_Id       | int       | int            | N        |             | FK          |            | ID of the course that contains a topic that has this question                                            |
| dbo         | Question         | Q\_ID            | int       | int            | N        | PK          |             |            | Primary key of the table                                                                                 |
| dbo         | Question         | Q\_Model\_Answer | varchar   | varchar(20)    | N        |             |             |            | Model answer of the question                                                                             |
| dbo         | Question         | Q\_Text          | varchar   | varchar(200)   | N        |             |             |            | Question itself                                                                                          |
| dbo         | Question         | Q\_Type          | varchar   | varchar(5)     | N        |             |             |            | Question type that is represnted by "T/F" or "MCQ"                                                       |
| dbo         | Student          | Leader\_ID       | int       | int            | Y        |             | FK          |            | ID of the student who supervises this student                                                            |
| dbo         | Student          | Std\_Age         | int       | int            | Y        |             |             |            | Student age                                                                                              |
| dbo         | Student          | Std\_Email       | varchar   | varchar(50)    | Y        |             |             | UK         | Student email that is used to send him his results in the exams                                          |
| dbo         | Student          | Std\_ID          | int       | int            | N        | PK          |             |            | Primary key of the table                                                                                 |
| dbo         | Student          | Std\_Name        | varchar   | varchar(50)    | N        |             |             |            | Student full name                                                                                        |
| dbo         | Student          | Std\_Password    | varchar   | varchar(250)   | Y        |             |             |            | Student passowrd that validates his identity to login to the examination system as "Student"             |
| dbo         | Student          | Std\_UserName    | varchar   | varchar(50)    | Y        |             |             | UK         | Student username that he uses to login to the examination system and take exams                          |
| dbo         | Student          | Track\_Id        | int       | int            | N        |             | FK          |            | ID of the track that the student is enrolled to                                                          |
| dbo         | Student\_Courses | Course\_Id       | int       | int            | N        | PK          | FK          |            | ID of a course taken by a specific student                                                               |
| dbo         | Student\_Courses | Grade            | int       | int            | Y        |             |             |            | Total grade for a specific student in a specific course                                                  |
| dbo         | Student\_Courses | Std\_ID          | int       | int            | N        | PK          | FK          |            | ID of a student who takes a specific bunch of courses                                                    |
| dbo         | Student\_Exam    | E\_ID            | int       | int            | N        | PK          | FK          |            | ID of an exam that was taken by a specific student and included specific questions                       |
| dbo         | Student\_Exam    | Q\_Grade         | int       | int            | Y        |             |             |            | Grade of question that is decided depending on the student answer                                        |
| dbo         | Student\_Exam    | Q\_ID            | int       | int            | N        | PK          | FK          |            | ID of a specific question existed in a specific exam and was answered by a specific student              |
| dbo         | Student\_Exam    | Std\_Answer      | varchar   | varchar(5)     | Y        |             |             |            | Answer of a specific quesetion in a specific exam by a specific student                                  |
| dbo         | Student\_Exam    | Std\_ID          | int       | int            | N        | PK          | FK          |            | ID of a student who took a specific exam that included specific questions                                |
| dbo         | sysdiagrams      | definition       | varbinary | varbinary(MAX) | Y        |             |             |            | NULL                                                                                                     |
| dbo         | sysdiagrams      | diagram\_id      | int       | int            | N        | PK          |             |            | NULL                                                                                                     |
| dbo         | sysdiagrams      | name             | sysname   | sysname        | N        |             |             | UK         | NULL                                                                                                     |
| dbo         | sysdiagrams      | principal\_id    | int       | int            | N        |             |             | UK         | NULL                                                                                                     |
| dbo         | sysdiagrams      | version          | int       | int            | Y        |             |             |            | NULL                                                                                                     |
| dbo         | Topic            | Course\_Id       | int       | int            | N        | PK          | FK          |            | ID of the course that contains this topic in its curriculum                                              |
| dbo         | Topic            | Topic\_Name      | varchar   | varchar(50)    | N        | PK          |             |            | Topic Name                                                                                               |
| dbo         | Track            | Super\_ID        | int       | int            | Y        |             | FK          |            | ID of the instructor who supervises this track                                                           |
| dbo         | Track            | Track\_Id        | int       | int            | N        | PK          |             |            | Primary key of the table                                                                                 |
| dbo         | Track            | Track\_Name      | varchar   | varchar(20)    | N        |             |             |            | Track name                                                                                               |
| dbo         | Track\_Courses   | Course\_Id       | int       | int            | N        | PK          | FK          |            | ID of a course that is being taught within a specific track                                              |
| dbo         | Track\_Courses   | Track\_Id        | int       | int            | N        | PK          | FK          |            | ID of a track, in which a specific bunch of courses is being taught                                      |

--------------------
## Examination System Application Features and Privileges
There are 3 main types of users for this application:
1.	### Instructors
2.	### Students 
3.	### Admin User
### Common Privileges among all users:
* Users’ data and accounts are strongly secured and cannot be accessed easily by anyone as passwords are stored in database as hashed passwords no one can understand or use them. 
*	When any user tries to login and enter his username and password, the application converts this password to hashed string then compares it with the hashed password saved in the database that is related to this username to ensure the identity of the user.
### Instructors Privileges:
*	Can create exams for any course he teaches at any time and it will be saved in the database.
*	Can change or extend the duration in which the exam is available for students to be examined.
*	Can add questions to the questions bank in the courses he teaches.
### Students Privileges:
*	Can view courses he is enrolled in but has not taken their exams yet and choose to be examined in one of them.
*	Can view his grades in all exams he had taken.
*	Can view his answers in previous exams and compare them with model answers.
### Admin User Privileges:
*	It is only one account that has the permission to access this sensitive part of the application.
*	Can view, edit and delete data of instructors, students, courses and tracks.
*	Can add instructors, students and courses to the system.
*	Can create exams on behalf of instructors depending on courses they teach.
*	Can view all kinds of reports.
-------------------- 
## Contributors
<table>
  <tr>
    <td align="center">
    <a href="https://github.com/mostafagad464" target="_black">
    <img src="https://avatars.githubusercontent.com/u/62313686?v=4" width="150px;" alt="Mostafa Gad "/>
    <br />
    <sub><b>Mostafa Gad </b></sub></a><br />
    </td>
    <td align="center">
    <a href="https://github.com/aliaamhmd" target="_black">
    <img src="https://avatars.githubusercontent.com/u/95531194?v=4" width="150px;" alt="Aliaa "/>
    <br />
    <sub><b> Aliaa</b></sub></a><br />
    </td>
    <td align="center">
    <a href="https://github.com/ahmedsamy1234" target="_black">
    <img src="https://avatars.githubusercontent.com/ahmedsamy1234" width="150px;" alt="ahmed samy"/>
    <br />
    <sub><b>Ahmed Samy</b></sub></a><br />
    </td>
    <td align="center">
    <a href="https://github.com/EsraaNouh" target="_black">
    <img src="https://avatars.githubusercontent.com/u/95531203?v=4" width="150px;" alt="Esraa Nouh"/>
    <br />
    <sub><b>Esraa Nouh</b></sub></a><br />
    </td>
    <td align="center">
    <a href="https://github.com/aya-attia" target="_black">
    <img src="https://avatars.githubusercontent.com/u/95532679?v=4" width="150px;" alt="Aya Attia"/>
    <br />
    <sub><b>Aya Attia</b></sub></a><br />
    </td>
    <td align="center">
    <a href="https://github.com/yarahmed" target="_black">
    <img src="https://avatars.githubusercontent.com/u/95531259?v=4" width="150px;" alt="Yara "/>
    <br />
    <sub><b>Yara </b></sub></a><br />
    </td>
    <td align="center">
    <a href="https://github.com/Mary-Akram" target="_black">
    <img src="https://avatars.githubusercontent.com/u/95533198?v=4" width="150px;" alt="Mary Akram "/>
    <br />
    <sub><b>Mary Akram  </b></sub></a><br />
    </td>
    

  </tr>

  
 </table>

<p align="center">
  <img width="150" src="https://github.com/ahmedsamy1234/Chest-X-Ray-Diagnosis/blob/main/tenor.gif">
</p>
