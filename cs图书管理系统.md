## 图书管理系统

### 主要功能：为用户提供查询、借阅、归还功能，管理员具有添加、删除、更改图书信息以及查询借阅情况。

#### 用户

- 查询
- 借阅
- 归还

#### 管理员

- 添加
- 删除
- 更改
- 查询借阅情况——————没做



###  数据库设计

#### 用户表(user)

| 字段     | 类型           | 备注                   |
| -------- | -------------- | ---------------------- |
| id       | int            | 主键、学号             |
| name     | varchar(30)    | 姓名                   |
| major    | varchar(30)    | 专业                   |
| grade    | int            | 年级+班级：1701        |
| sex      | varchar(3)     | 男/女                  |
| num      | int,default=20 | 可借阅量,默认为20本    |
| super    | int            | 0/1,0为管理员，1为学生 |
| password | varchar(20)    | 密码                   |

#### 图书表(book)

| 字段     | 类型        | 备注                 |
| -------- | ----------- | -------------------- |
| id       | int         | 主键，自增，图书编号 |
| title    | varchar(30) | 书名                 |
| author   | varchar(30) | 作者                 |
| press    | varchar(30) | 出版社               |
| num      | int         | 馆藏                 |
| remained | int         | 剩余可借数量         |
| place    | varchar(30) | 存放位置             |



#### 用户图书表(user_book)

| 字段        | 类型 | 备注         |
| ----------- | ---- | ------------ |
| id          | int  | 主键         |
| user_id     | int  | 关联用户id   |
| book_id     | int  | 关联图书id   |
| borrow_time | Date | 借阅时间     |
| revert_time | Date | 应归还时间   |
| give_back   | Date | 实际归还时间 |

