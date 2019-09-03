[1mdiff --git a/Otomasyon/.vs/Otomasyon/v16/.suo b/Otomasyon/.vs/Otomasyon/v16/.suo[m
[1mindex b82a48a..507ae9c 100644[m
Binary files a/Otomasyon/.vs/Otomasyon/v16/.suo and b/Otomasyon/.vs/Otomasyon/v16/.suo differ
[1mdiff --git a/Otomasyon/Otomasyon/StokModul/StokGruplari.cs b/Otomasyon/Otomasyon/StokModul/StokGruplari.cs[m
[1mindex e1c622c..13a20fe 100644[m
[1m--- a/Otomasyon/Otomasyon/StokModul/StokGruplari.cs[m
[1m+++ b/Otomasyon/Otomasyon/StokModul/StokGruplari.cs[m
[36m@@ -135,7 +135,7 @@[m [mnamespace Otomasyon.StokModul[m
 [m
         void grupListele()[m
         {[m
[31m-            var liste = from t in Fonksiyonlar.TBL_GRUPLAR select t;[m
[32m+[m[32m            var liste = from t in db.TBL_GRUPLAR select t;[m
             gridControl1.DataSource = liste;[m
         }[m
 [m
[1mdiff --git a/Otomasyon/Otomasyon/bin/Debug/Otomasyon.exe b/Otomasyon/Otomasyon/bin/Debug/Otomasyon.exe[m
[1mindex be36528..7b4e070 100644[m
Binary files a/Otomasyon/Otomasyon/bin/Debug/Otomasyon.exe and b/Otomasyon/Otomasyon/bin/Debug/Otomasyon.exe differ
[1mdiff --git a/Otomasyon/Otomasyon/bin/Debug/Otomasyon.pdb b/Otomasyon/Otomasyon/bin/Debug/Otomasyon.pdb[m
[1mindex ec05bef..a517b7d 100644[m
Binary files a/Otomasyon/Otomasyon/bin/Debug/Otomasyon.pdb and b/Otomasyon/Otomasyon/bin/Debug/Otomasyon.pdb differ
[1mdiff --git a/Otomasyon/Otomasyon/obj/Debug/Otomasyon.exe b/Otomasyon/Otomasyon/obj/Debug/Otomasyon.exe[m
[1mindex be36528..7b4e070 100644[m
Binary files a/Otomasyon/Otomasyon/obj/Debug/Otomasyon.exe and b/Otomasyon/Otomasyon/obj/Debug/Otomasyon.exe differ
[1mdiff --git a/Otomasyon/Otomasyon/obj/Debug/Otomasyon.pdb b/Otomasyon/Otomasyon/obj/Debug/Otomasyon.pdb[m
[1mindex ec05bef..a517b7d 100644[m
Binary files a/Otomasyon/Otomasyon/obj/Debug/Otomasyon.pdb and b/Otomasyon/Otomasyon/obj/Debug/Otomasyon.pdb differ
