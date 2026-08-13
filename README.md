# Calculator App (C# / .NET Console)

A small console calculator project meant purely for practice: opening in
Visual Studio 2022, pushing to GitHub, and practicing everyday Git
workflows (commits, branches, merge, rebase, pull requests).

## What's inside

```
CalculatorApp/
├── CalculatorApp.sln          <- open this in Visual Studio 2022
└── CalculatorApp/
    ├── CalculatorApp.csproj
    ├── Program.cs             <- console menu / entry point
    └── Calculator.cs          <- Add, Subtract, Multiply, Divide logic
```

It supports Add, Subtract, Multiply, and Divide (with a divide-by-zero
check) through a simple numbered menu in the console.

## Opening in Visual Studio 2022

1. Unzip the project anywhere on your machine.
2. Double-click `CalculatorApp.sln` — Visual Studio 2022 will open it.
3. Press **F5** (or the green ▶ Start button) to build and run.
4. .NET 8 SDK is required. If VS prompts you to install a missing
   workload/SDK, let it do so (or install the .NET 8 SDK from
   https://dotnet.microsoft.com/download first).

## Pushing this to GitHub

From inside the `CalculatorApp` folder (the one with the `.sln` file):

```bash
git init
git add .
git commit -m "Initial commit: basic calculator"
git branch -M main
git remote add origin https://github.com/<your-username>/<your-repo>.git
git push -u origin main
```

(Or create the empty repo on GitHub first and follow the "push an
existing repository" instructions GitHub shows you.)

## Practice ideas (good for learning Git commands)

- Add a new operation (e.g. `Power`, `SquareRoot`, `Modulus`,
  `Percentage`) in `Calculator.cs` on its own feature branch, then open
  a pull request.
- Practice `git rebase main` on your feature branch before merging, to
  keep history clean.
- Intentionally create a merge conflict (edit the same line on two
  branches) and practice resolving it.
- Add a `CalculatorApp.Tests` unit test project and practice commits
  around test-driven changes.
- Use `git log --oneline --graph --all` to visualize how rebase vs.
  merge change your commit history.

## License

Use freely for learning/practice purposes.
