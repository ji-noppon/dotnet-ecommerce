# Project Ecommerce

โปรเจคนี้เป็นตัวอย่างฝึกทำ **Clean Architecture** ด้วย **.NET 8+**
โดยออกแบบแยกเลเยอร์ชัดเจน เพื่อให้โค้ดสะอาด ดูแลง่าย และทดสอบง่าย

---

## โครงสร้างโปรเจค

- `/Api` - API Controllers, Middleware  
- `/Application` - Use Cases, Services, DTOs  
- `/Domain` - Entities, Interfaces, Business Logic  
- `/Infrastructure` - Data Access (EF Core), External Services, Dependency Injection
