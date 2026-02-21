# CLAUDE.md

Guidelines for AI-assisted development in this repository.

---

## 1. Code Generation Rules

When generating code:

- Target .NET 10
- Use C#
- Respect nullable reference types
- Follow Microsoft coding conventions
- Avoid reflection unless necessary
- Avoid dynamic typing

---

## 2. Architecture Rules

- Maintain package boundaries
- Do not introduce cross-package tight coupling
- Respect dependency direction
- Keep Core free from infrastructure dependencies

---

## 3. API Design Rules

- Public APIs must be minimal and explicit
- Prefer extension methods for optional behaviors
- Avoid breaking changes
- Use async/await properly
- Never block async calls

---

## 4. ASP.NET Core Extensions

If modifying `kr.bbon.AspNetCore`:

- Use IServiceCollection extension patterns
- Avoid directly accessing HttpContext unless necessary
- Follow middleware best practices

---

## 5. EF Core Extensions

If modifying `kr.bbon.EntityFrameworkCore.Extensions`:

- Do not override EF Core core behaviors
- Avoid hidden side effects
- Provide clear configuration APIs

---

## 6. Documentation

Generated code must:

- Include XML comments
- Include usage examples when appropriate
- Avoid unnecessary verbosity

---

## 7. Tests

Generated features must include:

- Unit tests
- Edge case tests
- Null validation tests

---

## 8. Security

- No hardcoded secrets
- No unsafe deserialization
- Validate external input

---

## 9. Output Language

Documentation default: English  
If Korean documentation is required, provide a separate file.