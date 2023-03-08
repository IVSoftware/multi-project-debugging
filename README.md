As I understand it, your Project A has started the Project B `.exe`. Something along these lines:

    Public Class ProjectAForm
        Private Sub ButtonRunProjectB_Click(sender As Object, e As EventArgs) Handles ButtonRunProjectB.Click
            Process.Start("D:\Github\stackoverflow\multi-project-debugging\project-b\bin\Debug\netcoreapp3.1\project-b.exe")
        End Sub
    End Class

You want to debug Project B in this context, but you're unattached:

[![not attached][1]][1]

***
**Manual**

The interactive way to go about it is with DEBUG\Attach to Process...

[![attach to process][2]][2]

Now you will hit your breakpoints.

[![attached][3]][3]

***
**Programmatic**

Doing this automatically is tricky but possible. Refer to this answer:

[Can I programmatically attach a running .NET 6 process to a running instance of Visual Studio debugger?](https://stackoverflow.com/a/72075450/5438626)

***
**Suggestion**

If Project A _doesn't_ reference Project B directly (that is, they're completely independent inside a common solution where Project A is the startup) I find that it saves a lot of confusion to have Project B build automatically (if needed) whenever Project A runs. Manually setting `project-a` to depend on `project-b` achieves this outcome.

[![project dependencies][4]][4]


  [1]: https://i.stack.imgur.com/XsNnC.png
  [2]: https://i.stack.imgur.com/mWiMm.png
  [3]: https://i.stack.imgur.com/aBbSp.png
  [4]: https://i.stack.imgur.com/8ypKG.png