# **Library Management System**

## **Overview**

The **Library Management System** is a robust and scalable solution designed to manage various aspects of a library's operations, including **book rentals**, **subscriber management**, and **categorization**. This system focuses on efficient data storage and relationships between entities to streamline workflows and ensure accurate record-keeping.

---

## **Database Design**
![image](https://github.com/user-attachments/assets/ea46e43a-a2af-48e5-9070-f1f309fc5a85)
![image](https://github.com/user-attachments/assets/190963ab-022d-458b-8299-a18f9bf3acba)

### **Key Features**

1. **Books Management**
   - **Books** are stored with detailed information such as **title**, **description**, **publication date**, **publisher**, and **pricing**.
   - Books can belong to multiple categories, enabling flexible classification through a **BookCategories** table.

2. **Book Copies**
   - Each book can have multiple physical copies tracked by **edition**, **serial number**, and **rental availability status**.

3. **Subscribers**
   - Subscribers are registered users of the library with essential details like **name**, **contact information**, and **subscription status**.
   - Each subscriber is linked to an **area** and **governorate**, ensuring precise localization.

4. **Rentals**
   - Tracks the borrowing and returning of books by subscribers.
   - Maintains important details such as **rental start and end dates**, **extensions**, and **payment status**.

5. **Subscriptions**
   - Manages subscriber membership periods by tracking **start and end dates**.

6. **Authors**
   - Stores detailed information about authors, including their **name** and **nationality**, for better management of book-related metadata.

7. **Categories**
   - Enables flexible grouping of books into various categories, making it easier to browse and filter the library catalog.

8. **Governance**
   - Detailed tables for managing **governorates** and **areas**, ensuring accurate regional mapping of subscribers and library branches.

9. **Authentication:**
   - User login
   - User registration
   - Password recovery (forget password)
   - Change password
   - Get user information
   - Confirm email address
   - Send verification code

10. **User Management:**

   - Complete CRUD operations for users

11. **Role Management:**

   - Role management with complete CRUD operations
---

### **Entity Relationships**

- **Books and BookCopies**: One book can have multiple copies, each tracked individually for rental management.
- **Books and Categories**: Many-to-many relationship via the **BookCategories** table, allowing books to belong to multiple categories.
- **Subscribers and Rentals**: Each subscriber can rent multiple books, tracked in the **Rentals** table.
- **Subscribers and Subscriptions**: Each subscriber can have a subscription period tracked through the **Subscriptions** table.
- **Governates and Areas**: Represents the geographical hierarchy, ensuring accurate mapping of subscribers to their locations.

---

## **Technical Highlights**

- **Relational Database Structure**:
   - Ensures **data normalization** and avoids redundancy through efficient table relationships.
   - Comprehensive tracking of user activities such as **rentals** and **subscriptions**.

- **Scalability**:
   - Designed to handle a growing number of **subscribers**, **books**, and **categories** efficiently.

- **Localization**:
   - Detailed mapping of subscribers to geographical areas, enabling libraries to manage regional services effectively.

---

## **Key Use Cases**

- **Book Rentals**: Enables subscribers to borrow and return books, with support for **extending rental periods**.
- **Subscription Management**: Tracks the **subscription periods** of users and their membership status.
- **Library Catalog**: Organizes books by **categories**, **authors**, and **availability**, providing an intuitive browsing experience.
- **Localization**: Manages library operations across different regions using precise **geographical data**.

---

## **Future Enhancements**

- **Advanced Search**: Incorporate search capabilities for subscribers to find books by **author**, **category**, or **availability**.
- **Reporting and Analytics**: Generate detailed reports for **rentals**, **subscriptions**, and **user engagement**.
- **Integration with Digital Library Systems**: Extend support for **eBooks** and **online rentals**.

---

## **Getting Started**

1. **Clone the repository**:
   ```bash
   git clone https://github.com/blalhamd/Bookify.git






