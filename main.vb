// Coded By FinlandProgramming //
www.youtube.com/finlandprogramming


Flashing Status:
AxSkype1.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOnline
        System.Threading.Thread.Sleep(75)
        AxSkype1.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusDoNotDisturb
        System.Threading.Thread.Sleep(75)
        AxSkype1.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusAway
        System.Threading.Thread.Sleep(75)
        AxSkype1.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusInvisible
        System.Threading.Thread.Sleep(75)


Change Status:
(Online)   AxSkype1.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOnline
(Away)   AxSkype1.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusAway
(Don't Disturb)   AxSkype1.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusDoNotDisturb
(Invisible)   AxSkype1.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusInvisible
(Offline)   AxSkype1.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOffline


Change Profile:
(Name) AxSkype1.CurrentUserProfile.FullName = TextBox1.Text
(Mood) AxSkype1.CurrentUserProfile.MoodText = TextBox2.Text
(About) AxSkype1.CurrentUserProfile.About = TextBox3.Text
(Language) AxSkype1.CurrentUserProfile.Languages = TextBox4.Text


Code For CheckBox1:
If CheckBox1.Checked = True Then
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
