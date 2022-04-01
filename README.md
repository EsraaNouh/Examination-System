

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

## Libraries, framwork and linraries  
* Entity frameWork
* SQL 
* .net



----------

# Pysical tables 

 <img width="1000" src="https://github.com/EsraaNouh/examinationsystemV1/blob/master/pysical%20table.png">
 
 ## Features of System 
 


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
