Public Class RegMsgBoxwOtherlabels
    Public Sub New(RegPath As String, Regkod As String)

        InitializeComponent()
        lbTajekoztatasMsgBox.Text = "Regisztráció sikeres a " & Regkod & " kóddal!" & Environment.NewLine & "Bemásolva a következő helyre: " & RegPath & Environment.NewLine & Environment.NewLine &
            "A regisztrációs állományról készítsen biztonsági másolatot - ugyanazzal a kóddal nem tud újra regisztrálni!" & Environment.NewLine &
            "Ha szeretné, hogy szükség esetén az ügyfélszolgálat oda tudja adni a regisztrációs fájlt, válassza alább a 'Feltöltés' gombot." & Environment.NewLine & Environment.NewLine &
            "Sikeres feltöltés esetén a regisztrációs fájlt a regisztrációs kódjához kapcsolódóan eltárolja egy magyarországi szerver, amelyet szükség esetén azonosítás után az ügyfélszolgálat elküld Önnek." & Environment.NewLine &
            "A tárolt regisztrációs állományt az ügyfélszolgálat kérésre bármikor törli."
    End Sub

End Class