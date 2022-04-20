# ความเป็นมาของโปรแกรม
การเช็คข้อมูลของคนเข้าออก เหมือนการเช็คชื่อในห้องเรียนหรือการเช็คการเข้าออกภายในโรงเรียนในตอนประถม
โปรแกรมนี้สามารถเช็คคนเข้าออกแล้วเก็บข้อมูลลง DataGridView เ พื่อ Export เป็นไฟล์ CSV สามารถเช็คย้อนหลังได้

# วัตถุประสงค์ของโปรแกรม
เพื่อพัฒนาระบบและอประเมินประสิทธิภาพเช็คชื่อผู้คนเข้าออก

# Class Diagram
```mermaid
classDiagram
  List <|--Form1
  direction LR
  class Form1{
  -Add()
  -Save As()
  class List{
  selectedRow:int
  -Add():void
  -Save As():void
  }
  class Form1{
  -Add
  -Save As
  +id() : string
  +titlename() : string
  +name() : string
  +surname() : string
  +date() : string
  +time() : string
  +inout() : string
  }
```
# ผู้พัฒนาโปรแกรม
นายก้องภพ ตาดี รหัสนักศึกษา 643450312-2
