# Contributing

Thanks for considering contributing! A few simple guidelines help maintain a smooth workflow.

How to contribute

1. Fork the repository and create a branch from `main` named `feature/your-topic` or `fix/issue-number`.
2. Make small, focused commits with clear messages.
3. Run the tests locally via the Unity Test Runner before opening a PR.
4. Open a Pull Request describing the change, linking any related issue.

PR checklist

- [ ] Follows existing code style (C# conventions used in Unity projects).
- [ ] No changes to runtime code that break existing behavior unless necessary and documented.
- [ ] Tests added or updated for new behavior.
- [ ] CI checks (if present) pass.

Code style

- Prefer clear, descriptive names for classes and methods.
- Keep Unity-specific code (Editor-only) inside `#if UNITY_EDITOR` or `Editor` folders.

Reporting issues

Use the issue templates when creating bug reports or feature requests.
