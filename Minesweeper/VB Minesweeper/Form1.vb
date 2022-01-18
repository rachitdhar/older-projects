Public Class Form1

    Dim has_mine(2400) As Boolean
    Dim first_click As Boolean = True
    Dim mines As Integer = 0
    Dim clr_code As Color = Drawing.Color.DodgerBlue
    Dim b_completed As Integer = 0
    Dim btn_check As Button
    Dim b_code As Button
    Dim minimum_mines As Integer = 275
    Dim num_clr(8) As Color
    Dim purple As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Randomize()
        My.Settings.check = False
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        num_clr(0) = Drawing.Color.Blue
        num_clr(1) = Drawing.Color.Green
        num_clr(2) = Drawing.Color.Red
        num_clr(3) = Drawing.Color.DarkBlue
        num_clr(4) = Drawing.Color.Maroon
        num_clr(5) = Drawing.Color.LightSeaGreen
        num_clr(6) = Drawing.Color.Black
        num_clr(7) = Drawing.Color.Gray
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox2.Text += 1
        If purple = False Then
            If My.Settings.check = True Then
                b_completed = 0
                For Each Obj As Object In Me.Controls
                    If Obj.GetType Is GetType(Button) Then
                        If Not DirectCast(Obj, Button).Name = "b_image" Then
                            If Not DirectCast(Obj, Button).Name = "non_image" Then
                                If Not DirectCast(Obj, Button).Name = "b_flag" Then
                                    If has_mine(b_completed) = True Then
                                        DirectCast(Obj, Button).BackColor = Drawing.Color.Purple
                                    End If
                                    b_completed += 1
                                End If
                            End If
                        End If
                    End If
                Next
                b_completed = 0
                purple = True
            End If
        End If
    End Sub

    Private Sub btn_MouseDown(sender As Object, e As MouseEventArgs) Handles b99.MouseDown, b98.MouseDown, b97.MouseDown, b96.MouseDown, b95.MouseDown, b94.MouseDown, b93.MouseDown, b92.MouseDown, b91.MouseDown, b90.MouseDown, b9.MouseDown, b89.MouseDown, b88.MouseDown, b87.MouseDown, b86.MouseDown, b85.MouseDown, b84.MouseDown, b83.MouseDown, b82.MouseDown, b81.MouseDown, b80.MouseDown, b8.MouseDown, b79.MouseDown, b78.MouseDown, b77.MouseDown, b76.MouseDown, b75.MouseDown, b74.MouseDown, b73.MouseDown, b72.MouseDown, b71.MouseDown, b70.MouseDown, b7.MouseDown, b69.MouseDown, b68.MouseDown, b67.MouseDown, b66.MouseDown, b65.MouseDown, b64.MouseDown, b63.MouseDown, b62.MouseDown, b61.MouseDown, b60.MouseDown, b6.MouseDown, b59.MouseDown, b58.MouseDown, b57.MouseDown, b56.MouseDown, b55.MouseDown, b54.MouseDown, b53.MouseDown, b52.MouseDown, b51.MouseDown, b50.MouseDown, b5.MouseDown, b49.MouseDown, b48.MouseDown, b47.MouseDown, b46.MouseDown, b45.MouseDown, b44.MouseDown, b43.MouseDown, b42.MouseDown, b41.MouseDown, b400.MouseDown, b40.MouseDown, b4.MouseDown, b399.MouseDown, b398.MouseDown, b397.MouseDown, b396.MouseDown, b395.MouseDown, b394.MouseDown, b393.MouseDown, b392.MouseDown, b391.MouseDown, b390.MouseDown, b39.MouseDown, b389.MouseDown, b388.MouseDown, b387.MouseDown, b386.MouseDown, b385.MouseDown, b384.MouseDown, b383.MouseDown, b382.MouseDown, b381.MouseDown, b380.MouseDown, b38.MouseDown, b379.MouseDown, b378.MouseDown, b377.MouseDown, b376.MouseDown, b375.MouseDown, b374.MouseDown, b373.MouseDown, b372.MouseDown, b371.MouseDown, b370.MouseDown, b37.MouseDown, b369.MouseDown, b368.MouseDown, b367.MouseDown, b366.MouseDown, b365.MouseDown, b364.MouseDown, b363.MouseDown, b362.MouseDown, b361.MouseDown, b360.MouseDown, b36.MouseDown, b359.MouseDown, b358.MouseDown, b357.MouseDown, b356.MouseDown, b355.MouseDown, b354.MouseDown, b353.MouseDown, b352.MouseDown, b351.MouseDown, b350.MouseDown, b35.MouseDown, b349.MouseDown, b348.MouseDown, b347.MouseDown, b346.MouseDown, b345.MouseDown, b344.MouseDown, b343.MouseDown, b342.MouseDown, b341.MouseDown, b340.MouseDown, b34.MouseDown, b339.MouseDown, b338.MouseDown, b337.MouseDown, b336.MouseDown, b335.MouseDown, b334.MouseDown, b333.MouseDown, b332.MouseDown, b331.MouseDown, b330.MouseDown, b33.MouseDown, b329.MouseDown, b328.MouseDown, b327.MouseDown, b326.MouseDown, b325.MouseDown, b324.MouseDown, b323.MouseDown, b322.MouseDown, b321.MouseDown, b320.MouseDown, b32.MouseDown, b319.MouseDown, b318.MouseDown, b317.MouseDown, b316.MouseDown, b315.MouseDown, b314.MouseDown, b313.MouseDown, b312.MouseDown, b311.MouseDown, b310.MouseDown, b31.MouseDown, b309.MouseDown, b308.MouseDown, b307.MouseDown, b306.MouseDown, b305.MouseDown, b304.MouseDown, b303.MouseDown, b302.MouseDown, b301.MouseDown, b300.MouseDown, b30.MouseDown, b3.MouseDown, b299.MouseDown, b298.MouseDown, b297.MouseDown, b296.MouseDown, b295.MouseDown, b294.MouseDown, b293.MouseDown, b292.MouseDown, b291.MouseDown, b290.MouseDown, b29.MouseDown, b289.MouseDown, b288.MouseDown, b287.MouseDown, b286.MouseDown, b285.MouseDown, b284.MouseDown, b283.MouseDown, b282.MouseDown, b281.MouseDown, b280.MouseDown, b28.MouseDown, b279.MouseDown, b278.MouseDown, b277.MouseDown, b276.MouseDown, b275.MouseDown, b274.MouseDown, b273.MouseDown, b272.MouseDown, b271.MouseDown, b270.MouseDown, b27.MouseDown, b269.MouseDown, b268.MouseDown, b267.MouseDown, b266.MouseDown, b265.MouseDown, b264.MouseDown, b263.MouseDown, b262.MouseDown, b261.MouseDown, b260.MouseDown, b26.MouseDown, b259.MouseDown, b258.MouseDown, b257.MouseDown, b256.MouseDown, b255.MouseDown, b254.MouseDown, b253.MouseDown, b252.MouseDown, b251.MouseDown, b250.MouseDown, b25.MouseDown, b249.MouseDown, b248.MouseDown, b247.MouseDown, b246.MouseDown, b245.MouseDown, b244.MouseDown, b243.MouseDown, b242.MouseDown, b241.MouseDown, b240.MouseDown, b24.MouseDown, b239.MouseDown, b238.MouseDown, b237.MouseDown, b236.MouseDown, b235.MouseDown, b234.MouseDown, b233.MouseDown, b232.MouseDown, b231.MouseDown, b230.MouseDown, b23.MouseDown, b229.MouseDown, b228.MouseDown, b227.MouseDown, b226.MouseDown, b225.MouseDown, b224.MouseDown, b223.MouseDown, b222.MouseDown, b221.MouseDown, b220.MouseDown, b22.MouseDown, b219.MouseDown, b218.MouseDown, b217.MouseDown, b216.MouseDown, b215.MouseDown, b214.MouseDown, b213.MouseDown, b212.MouseDown, b211.MouseDown, b210.MouseDown, b21.MouseDown, b209.MouseDown, b208.MouseDown, b207.MouseDown, b206.MouseDown, b205.MouseDown, b204.MouseDown, b203.MouseDown, b202.MouseDown, b201.MouseDown, b200.MouseDown, b20.MouseDown, b2.MouseDown, b199.MouseDown, b198.MouseDown, b197.MouseDown, b196.MouseDown, b195.MouseDown, b194.MouseDown, b193.MouseDown, b192.MouseDown, b191.MouseDown, b190.MouseDown, b19.MouseDown, b189.MouseDown, b188.MouseDown, b187.MouseDown, b186.MouseDown, b185.MouseDown, b184.MouseDown, b183.MouseDown, b182.MouseDown, b181.MouseDown, b180.MouseDown, b18.MouseDown, b179.MouseDown, b178.MouseDown, b177.MouseDown, b176.MouseDown, b175.MouseDown, b174.MouseDown, b173.MouseDown, b172.MouseDown, b171.MouseDown, b170.MouseDown, b17.MouseDown, b169.MouseDown, b168.MouseDown, b167.MouseDown, b166.MouseDown, b165.MouseDown, b164.MouseDown, b163.MouseDown, b162.MouseDown, b161.MouseDown, b160.MouseDown, b16.MouseDown, b159.MouseDown, b158.MouseDown, b157.MouseDown, b156.MouseDown, b155.MouseDown, b154.MouseDown, b153.MouseDown, b152.MouseDown, b151.MouseDown, b150.MouseDown, b15.MouseDown, b149.MouseDown, b148.MouseDown, b147.MouseDown, b146.MouseDown, b145.MouseDown, b144.MouseDown, b143.MouseDown, b142.MouseDown, b141.MouseDown, b140.MouseDown, b14.MouseDown, b139.MouseDown, b138.MouseDown, b137.MouseDown, b136.MouseDown, b135.MouseDown, b134.MouseDown, b133.MouseDown, b132.MouseDown, b131.MouseDown, b130.MouseDown, b13.MouseDown, b129.MouseDown, b128.MouseDown, b127.MouseDown, b126.MouseDown, b125.MouseDown, b124.MouseDown, b123.MouseDown, b122.MouseDown, b121.MouseDown, b120.MouseDown, b12.MouseDown, b119.MouseDown, b118.MouseDown, b117.MouseDown, b116.MouseDown, b115.MouseDown, b114.MouseDown, b113.MouseDown, b112.MouseDown, b111.MouseDown, b110.MouseDown, b11.MouseDown, b109.MouseDown, b108.MouseDown, b107.MouseDown, b106.MouseDown, b105.MouseDown, b104.MouseDown, b103.MouseDown, b102.MouseDown, b101.MouseDown, b100.MouseDown, b10.MouseDown, b1.MouseDown, Button99.MouseDown, Button98.MouseDown, Button97.MouseDown, Button96.MouseDown, Button95.MouseDown, Button94.MouseDown, Button93.MouseDown, Button92.MouseDown, Button91.MouseDown, Button90.MouseDown, Button9.MouseDown, Button89.MouseDown, Button88.MouseDown, Button87.MouseDown, Button86.MouseDown, Button85.MouseDown, Button84.MouseDown, Button83.MouseDown, Button82.MouseDown, Button81.MouseDown, Button80.MouseDown, Button8.MouseDown, Button79.MouseDown, Button78.MouseDown, Button77.MouseDown, Button76.MouseDown, Button75.MouseDown, Button74.MouseDown, Button73.MouseDown, Button72.MouseDown, Button71.MouseDown, Button70.MouseDown, Button7.MouseDown, Button69.MouseDown, Button68.MouseDown, Button67.MouseDown, Button66.MouseDown, Button65.MouseDown, Button64.MouseDown, Button63.MouseDown, Button62.MouseDown, Button61.MouseDown, Button60.MouseDown, Button6.MouseDown, Button59.MouseDown, Button58.MouseDown, Button57.MouseDown, Button56.MouseDown, Button55.MouseDown, Button54.MouseDown, Button53.MouseDown, Button52.MouseDown, Button51.MouseDown, Button50.MouseDown, Button5.MouseDown, Button49.MouseDown, Button48.MouseDown, Button47.MouseDown, Button46.MouseDown, Button45.MouseDown, Button44.MouseDown, Button43.MouseDown, Button42.MouseDown, Button41.MouseDown, Button400.MouseDown, Button40.MouseDown, Button4.MouseDown, Button399.MouseDown, Button398.MouseDown, Button397.MouseDown, Button396.MouseDown, Button395.MouseDown, Button394.MouseDown, Button393.MouseDown, Button392.MouseDown, Button391.MouseDown, Button390.MouseDown, Button39.MouseDown, Button389.MouseDown, Button388.MouseDown, Button387.MouseDown, Button386.MouseDown, Button385.MouseDown, Button384.MouseDown, Button383.MouseDown, Button382.MouseDown, Button381.MouseDown, Button380.MouseDown, Button38.MouseDown, Button379.MouseDown, Button378.MouseDown, Button377.MouseDown, Button376.MouseDown, Button375.MouseDown, Button374.MouseDown, Button373.MouseDown, Button372.MouseDown, Button371.MouseDown, Button370.MouseDown, Button37.MouseDown, Button369.MouseDown, Button368.MouseDown, Button367.MouseDown, Button366.MouseDown, Button365.MouseDown, Button364.MouseDown, Button363.MouseDown, Button362.MouseDown, Button361.MouseDown, Button360.MouseDown, Button36.MouseDown, Button359.MouseDown, Button358.MouseDown, Button357.MouseDown, Button356.MouseDown, Button355.MouseDown, Button354.MouseDown, Button353.MouseDown, Button352.MouseDown, Button351.MouseDown, Button350.MouseDown, Button35.MouseDown, Button349.MouseDown, Button348.MouseDown, Button347.MouseDown, Button346.MouseDown, Button345.MouseDown, Button344.MouseDown, Button343.MouseDown, Button342.MouseDown, Button341.MouseDown, Button340.MouseDown, Button34.MouseDown, Button339.MouseDown, Button338.MouseDown, Button337.MouseDown, Button336.MouseDown, Button335.MouseDown, Button334.MouseDown, Button333.MouseDown, Button332.MouseDown, Button331.MouseDown, Button330.MouseDown, Button33.MouseDown, Button329.MouseDown, Button328.MouseDown, Button327.MouseDown, Button326.MouseDown, Button325.MouseDown, Button324.MouseDown, Button323.MouseDown, Button322.MouseDown, Button321.MouseDown, Button320.MouseDown, Button32.MouseDown, Button319.MouseDown, Button318.MouseDown, Button317.MouseDown, Button316.MouseDown, Button315.MouseDown, Button314.MouseDown, Button313.MouseDown, Button312.MouseDown, Button311.MouseDown, Button310.MouseDown, Button31.MouseDown, Button309.MouseDown, Button308.MouseDown, Button307.MouseDown, Button306.MouseDown, Button305.MouseDown, Button304.MouseDown, Button303.MouseDown, Button302.MouseDown, Button301.MouseDown, Button300.MouseDown, Button30.MouseDown, Button3.MouseDown, Button299.MouseDown, Button298.MouseDown, Button297.MouseDown, Button296.MouseDown, Button295.MouseDown, Button294.MouseDown, Button293.MouseDown, Button292.MouseDown, Button291.MouseDown, Button290.MouseDown, Button29.MouseDown, Button289.MouseDown, Button288.MouseDown, Button287.MouseDown, Button286.MouseDown, Button285.MouseDown, Button284.MouseDown, Button283.MouseDown, Button282.MouseDown, Button281.MouseDown, Button280.MouseDown, Button28.MouseDown, Button279.MouseDown, Button278.MouseDown, Button277.MouseDown, Button276.MouseDown, Button275.MouseDown, Button274.MouseDown, Button273.MouseDown, Button272.MouseDown, Button271.MouseDown, Button270.MouseDown, Button27.MouseDown, Button269.MouseDown, Button268.MouseDown, Button267.MouseDown, Button266.MouseDown, Button265.MouseDown, Button264.MouseDown, Button263.MouseDown, Button262.MouseDown, Button261.MouseDown, Button260.MouseDown, Button26.MouseDown, Button259.MouseDown, Button258.MouseDown, Button257.MouseDown, Button256.MouseDown, Button255.MouseDown, Button254.MouseDown, Button253.MouseDown, Button252.MouseDown, Button251.MouseDown, Button250.MouseDown, Button25.MouseDown, Button249.MouseDown, Button248.MouseDown, Button247.MouseDown, Button246.MouseDown, Button245.MouseDown, Button244.MouseDown, Button243.MouseDown, Button242.MouseDown, Button241.MouseDown, Button240.MouseDown, Button24.MouseDown, Button239.MouseDown, Button238.MouseDown, Button237.MouseDown, Button236.MouseDown, Button235.MouseDown, Button234.MouseDown, Button233.MouseDown, Button232.MouseDown, Button231.MouseDown, Button230.MouseDown, Button23.MouseDown, Button229.MouseDown, Button228.MouseDown, Button227.MouseDown, Button226.MouseDown, Button225.MouseDown, Button224.MouseDown, Button223.MouseDown, Button222.MouseDown, Button221.MouseDown, Button220.MouseDown, Button22.MouseDown, Button219.MouseDown, Button218.MouseDown, Button217.MouseDown, Button216.MouseDown, Button215.MouseDown, Button214.MouseDown, Button213.MouseDown, Button212.MouseDown, Button211.MouseDown, Button210.MouseDown, Button21.MouseDown, Button209.MouseDown, Button208.MouseDown, Button207.MouseDown, Button206.MouseDown, Button205.MouseDown, Button204.MouseDown, Button203.MouseDown, Button202.MouseDown, Button201.MouseDown, Button200.MouseDown, Button20.MouseDown, Button2.MouseDown, Button199.MouseDown, Button198.MouseDown, Button197.MouseDown, Button196.MouseDown, Button195.MouseDown, Button194.MouseDown, Button193.MouseDown, Button192.MouseDown, Button191.MouseDown, Button190.MouseDown, Button19.MouseDown, Button189.MouseDown, Button188.MouseDown, Button187.MouseDown, Button186.MouseDown, Button185.MouseDown, Button184.MouseDown, Button183.MouseDown, Button182.MouseDown, Button181.MouseDown, Button180.MouseDown, Button18.MouseDown, Button179.MouseDown, Button178.MouseDown, Button177.MouseDown, Button176.MouseDown, Button175.MouseDown, Button174.MouseDown, Button173.MouseDown, Button172.MouseDown, Button171.MouseDown, Button170.MouseDown, Button17.MouseDown, Button169.MouseDown, Button168.MouseDown, Button167.MouseDown, Button166.MouseDown, Button165.MouseDown, Button164.MouseDown, Button163.MouseDown, Button162.MouseDown, Button161.MouseDown, Button160.MouseDown, Button16.MouseDown, Button159.MouseDown, Button158.MouseDown, Button157.MouseDown, Button156.MouseDown, Button155.MouseDown, Button154.MouseDown, Button153.MouseDown, Button152.MouseDown, Button151.MouseDown, Button150.MouseDown, Button15.MouseDown, Button149.MouseDown, Button148.MouseDown, Button147.MouseDown, Button146.MouseDown, Button145.MouseDown, Button144.MouseDown, Button143.MouseDown, Button142.MouseDown, Button141.MouseDown, Button140.MouseDown, Button14.MouseDown, Button139.MouseDown, Button138.MouseDown, Button137.MouseDown, Button136.MouseDown, Button135.MouseDown, Button134.MouseDown, Button133.MouseDown, Button132.MouseDown, Button131.MouseDown, Button130.MouseDown, Button13.MouseDown, Button129.MouseDown, Button128.MouseDown, Button127.MouseDown, Button126.MouseDown, Button125.MouseDown, Button124.MouseDown, Button123.MouseDown, Button122.MouseDown, Button121.MouseDown, Button120.MouseDown, Button12.MouseDown, Button119.MouseDown, Button118.MouseDown, Button117.MouseDown, Button116.MouseDown, Button115.MouseDown, Button114.MouseDown, Button113.MouseDown, Button112.MouseDown, Button111.MouseDown, Button110.MouseDown, Button11.MouseDown, Button109.MouseDown, Button108.MouseDown, Button107.MouseDown, Button106.MouseDown, Button105.MouseDown, Button104.MouseDown, Button103.MouseDown, Button102.MouseDown, Button101.MouseDown, Button100.MouseDown, Button10.MouseDown, Button1.MouseDown, Button999.MouseDown, Button998.MouseDown, Button997.MouseDown, Button996.MouseDown, Button995.MouseDown, Button994.MouseDown, Button993.MouseDown, Button992.MouseDown, Button991.MouseDown, Button990.MouseDown, Button989.MouseDown, Button988.MouseDown, Button987.MouseDown, Button986.MouseDown, Button985.MouseDown, Button984.MouseDown, Button983.MouseDown, Button982.MouseDown, Button981.MouseDown, Button980.MouseDown, Button979.MouseDown, Button978.MouseDown, Button977.MouseDown, Button976.MouseDown, Button975.MouseDown, Button974.MouseDown, Button973.MouseDown, Button972.MouseDown, Button971.MouseDown, Button970.MouseDown, Button969.MouseDown, Button968.MouseDown, Button967.MouseDown, Button966.MouseDown, Button965.MouseDown, Button964.MouseDown, Button963.MouseDown, Button962.MouseDown, Button961.MouseDown, Button960.MouseDown, Button959.MouseDown, Button958.MouseDown, Button957.MouseDown, Button956.MouseDown, Button955.MouseDown, Button954.MouseDown, Button953.MouseDown, Button952.MouseDown, Button951.MouseDown, Button950.MouseDown, Button949.MouseDown, Button948.MouseDown, Button947.MouseDown, Button946.MouseDown, Button945.MouseDown, Button944.MouseDown, Button943.MouseDown, Button942.MouseDown, Button941.MouseDown, Button940.MouseDown, Button939.MouseDown, Button938.MouseDown, Button937.MouseDown, Button936.MouseDown, Button935.MouseDown, Button934.MouseDown, Button933.MouseDown, Button932.MouseDown, Button931.MouseDown, Button930.MouseDown, Button929.MouseDown, Button928.MouseDown, Button927.MouseDown, Button926.MouseDown, Button925.MouseDown, Button924.MouseDown, Button923.MouseDown, Button922.MouseDown, Button921.MouseDown, Button920.MouseDown, Button919.MouseDown, Button918.MouseDown, Button917.MouseDown, Button916.MouseDown, Button915.MouseDown, Button914.MouseDown, Button913.MouseDown, Button912.MouseDown, Button911.MouseDown, Button910.MouseDown, Button909.MouseDown, Button908.MouseDown, Button907.MouseDown, Button906.MouseDown, Button905.MouseDown, Button904.MouseDown, Button903.MouseDown, Button902.MouseDown, Button901.MouseDown, Button900.MouseDown, Button899.MouseDown, Button898.MouseDown, Button897.MouseDown, Button896.MouseDown, Button895.MouseDown, Button894.MouseDown, Button893.MouseDown, Button892.MouseDown, Button891.MouseDown, Button890.MouseDown, Button889.MouseDown, Button888.MouseDown, Button887.MouseDown, Button886.MouseDown, Button885.MouseDown, Button884.MouseDown, Button883.MouseDown, Button882.MouseDown, Button881.MouseDown, Button880.MouseDown, Button879.MouseDown, Button878.MouseDown, Button877.MouseDown, Button876.MouseDown, Button875.MouseDown, Button874.MouseDown, Button873.MouseDown, Button872.MouseDown, Button871.MouseDown, Button870.MouseDown, Button869.MouseDown, Button868.MouseDown, Button867.MouseDown, Button866.MouseDown, Button865.MouseDown, Button864.MouseDown, Button863.MouseDown, Button862.MouseDown, Button861.MouseDown, Button860.MouseDown, Button859.MouseDown, Button858.MouseDown, Button857.MouseDown, Button856.MouseDown, Button855.MouseDown, Button854.MouseDown, Button853.MouseDown, Button852.MouseDown, Button851.MouseDown, Button850.MouseDown, Button849.MouseDown, Button848.MouseDown, Button847.MouseDown, Button846.MouseDown, Button845.MouseDown, Button844.MouseDown, Button843.MouseDown, Button842.MouseDown, Button841.MouseDown, Button840.MouseDown, Button839.MouseDown, Button838.MouseDown, Button837.MouseDown, Button836.MouseDown, Button835.MouseDown, Button834.MouseDown, Button833.MouseDown, Button832.MouseDown, Button831.MouseDown, Button830.MouseDown, Button829.MouseDown, Button828.MouseDown, Button827.MouseDown, Button826.MouseDown, Button825.MouseDown, Button824.MouseDown, Button823.MouseDown, Button822.MouseDown, Button821.MouseDown, Button820.MouseDown, Button819.MouseDown, Button818.MouseDown, Button817.MouseDown, Button816.MouseDown, Button815.MouseDown, Button814.MouseDown, Button813.MouseDown, Button812.MouseDown, Button811.MouseDown, Button810.MouseDown, Button809.MouseDown, Button808.MouseDown, Button807.MouseDown, Button806.MouseDown, Button805.MouseDown, Button804.MouseDown, Button803.MouseDown, Button802.MouseDown, Button801.MouseDown, Button800.MouseDown, Button799.MouseDown, Button798.MouseDown, Button797.MouseDown, Button796.MouseDown, Button795.MouseDown, Button794.MouseDown, Button793.MouseDown, Button792.MouseDown, Button791.MouseDown, Button790.MouseDown, Button789.MouseDown, Button788.MouseDown, Button787.MouseDown, Button786.MouseDown, Button785.MouseDown, Button784.MouseDown, Button783.MouseDown, Button782.MouseDown, Button781.MouseDown, Button780.MouseDown, Button779.MouseDown, Button778.MouseDown, Button777.MouseDown, Button776.MouseDown, Button775.MouseDown, Button774.MouseDown, Button773.MouseDown, Button772.MouseDown, Button771.MouseDown, Button770.MouseDown, Button769.MouseDown, Button768.MouseDown, Button767.MouseDown, Button766.MouseDown, Button765.MouseDown, Button764.MouseDown, Button763.MouseDown, Button762.MouseDown, Button761.MouseDown, Button760.MouseDown, Button759.MouseDown, Button758.MouseDown, Button757.MouseDown, Button756.MouseDown, Button755.MouseDown, Button754.MouseDown, Button753.MouseDown, Button752.MouseDown, Button751.MouseDown, Button750.MouseDown, Button749.MouseDown, Button748.MouseDown, Button747.MouseDown, Button746.MouseDown, Button745.MouseDown, Button744.MouseDown, Button743.MouseDown, Button742.MouseDown, Button741.MouseDown, Button740.MouseDown, Button739.MouseDown, Button738.MouseDown, Button737.MouseDown, Button736.MouseDown, Button735.MouseDown, Button734.MouseDown, Button733.MouseDown, Button732.MouseDown, Button731.MouseDown, Button730.MouseDown, Button729.MouseDown, Button728.MouseDown, Button727.MouseDown, Button726.MouseDown, Button725.MouseDown, Button724.MouseDown, Button723.MouseDown, Button722.MouseDown, Button721.MouseDown, Button720.MouseDown, Button719.MouseDown, Button718.MouseDown, Button717.MouseDown, Button716.MouseDown, Button715.MouseDown, Button714.MouseDown, Button713.MouseDown, Button712.MouseDown, Button711.MouseDown, Button710.MouseDown, Button709.MouseDown, Button708.MouseDown, Button707.MouseDown, Button706.MouseDown, Button705.MouseDown, Button704.MouseDown, Button703.MouseDown, Button702.MouseDown, Button701.MouseDown, Button700.MouseDown, Button699.MouseDown, Button698.MouseDown, Button697.MouseDown, Button696.MouseDown, Button695.MouseDown, Button694.MouseDown, Button693.MouseDown, Button692.MouseDown, Button691.MouseDown, Button690.MouseDown, Button689.MouseDown, Button688.MouseDown, Button687.MouseDown, Button686.MouseDown, Button685.MouseDown, Button684.MouseDown, Button683.MouseDown, Button682.MouseDown, Button681.MouseDown, Button680.MouseDown, Button679.MouseDown, Button678.MouseDown, Button677.MouseDown, Button676.MouseDown, Button675.MouseDown, Button674.MouseDown, Button673.MouseDown, Button672.MouseDown, Button671.MouseDown, Button670.MouseDown, Button669.MouseDown, Button668.MouseDown, Button667.MouseDown, Button666.MouseDown, Button665.MouseDown, Button664.MouseDown, Button663.MouseDown, Button662.MouseDown, Button661.MouseDown, Button660.MouseDown, Button659.MouseDown, Button658.MouseDown, Button657.MouseDown, Button656.MouseDown, Button655.MouseDown, Button654.MouseDown, Button653.MouseDown, Button652.MouseDown, Button651.MouseDown, Button650.MouseDown, Button649.MouseDown, Button648.MouseDown, Button647.MouseDown, Button646.MouseDown, Button645.MouseDown, Button644.MouseDown, Button643.MouseDown, Button642.MouseDown, Button641.MouseDown, Button640.MouseDown, Button639.MouseDown, Button638.MouseDown, Button637.MouseDown, Button636.MouseDown, Button635.MouseDown, Button634.MouseDown, Button633.MouseDown, Button632.MouseDown, Button631.MouseDown, Button630.MouseDown, Button629.MouseDown, Button628.MouseDown, Button627.MouseDown, Button626.MouseDown, Button625.MouseDown, Button624.MouseDown, Button623.MouseDown, Button622.MouseDown, Button621.MouseDown, Button620.MouseDown, Button619.MouseDown, Button618.MouseDown, Button617.MouseDown, Button616.MouseDown, Button615.MouseDown, Button614.MouseDown, Button613.MouseDown, Button612.MouseDown, Button611.MouseDown, Button610.MouseDown, Button609.MouseDown, Button608.MouseDown, Button607.MouseDown, Button606.MouseDown, Button605.MouseDown, Button604.MouseDown, Button603.MouseDown, Button602.MouseDown, Button601.MouseDown, Button600.MouseDown, Button599.MouseDown, Button598.MouseDown, Button597.MouseDown, Button596.MouseDown, Button595.MouseDown, Button594.MouseDown, Button593.MouseDown, Button592.MouseDown, Button591.MouseDown, Button590.MouseDown, Button589.MouseDown, Button588.MouseDown, Button587.MouseDown, Button586.MouseDown, Button585.MouseDown, Button584.MouseDown, Button583.MouseDown, Button582.MouseDown, Button581.MouseDown, Button580.MouseDown, Button579.MouseDown, Button578.MouseDown, Button577.MouseDown, Button576.MouseDown, Button575.MouseDown, Button574.MouseDown, Button573.MouseDown, Button572.MouseDown, Button571.MouseDown, Button570.MouseDown, Button569.MouseDown, Button568.MouseDown, Button567.MouseDown, Button566.MouseDown, Button565.MouseDown, Button564.MouseDown, Button563.MouseDown, Button562.MouseDown, Button561.MouseDown, Button560.MouseDown, Button559.MouseDown, Button558.MouseDown, Button557.MouseDown, Button556.MouseDown, Button555.MouseDown, Button554.MouseDown, Button553.MouseDown, Button552.MouseDown, Button551.MouseDown, Button550.MouseDown, Button549.MouseDown, Button548.MouseDown, Button547.MouseDown, Button546.MouseDown, Button545.MouseDown, Button544.MouseDown, Button543.MouseDown, Button542.MouseDown, Button541.MouseDown, Button540.MouseDown, Button539.MouseDown, Button538.MouseDown, Button537.MouseDown, Button536.MouseDown, Button535.MouseDown, Button534.MouseDown, Button533.MouseDown, Button532.MouseDown, Button531.MouseDown, Button530.MouseDown, Button529.MouseDown, Button528.MouseDown, Button527.MouseDown, Button526.MouseDown, Button525.MouseDown, Button524.MouseDown, Button523.MouseDown, Button522.MouseDown, Button521.MouseDown, Button520.MouseDown, Button519.MouseDown, Button518.MouseDown, Button517.MouseDown, Button516.MouseDown, Button515.MouseDown, Button514.MouseDown, Button513.MouseDown, Button512.MouseDown, Button511.MouseDown, Button510.MouseDown, Button509.MouseDown, Button508.MouseDown, Button507.MouseDown, Button506.MouseDown, Button505.MouseDown, Button504.MouseDown, Button503.MouseDown, Button502.MouseDown, Button501.MouseDown, Button500.MouseDown, Button499.MouseDown, Button498.MouseDown, Button497.MouseDown, Button496.MouseDown, Button495.MouseDown, Button494.MouseDown, Button493.MouseDown, Button492.MouseDown, Button491.MouseDown, Button490.MouseDown, Button489.MouseDown, Button488.MouseDown, Button487.MouseDown, Button486.MouseDown, Button485.MouseDown, Button484.MouseDown, Button483.MouseDown, Button482.MouseDown, Button481.MouseDown, Button480.MouseDown, Button479.MouseDown, Button478.MouseDown, Button477.MouseDown, Button476.MouseDown, Button475.MouseDown, Button474.MouseDown, Button473.MouseDown, Button472.MouseDown, Button471.MouseDown, Button470.MouseDown, Button469.MouseDown, Button468.MouseDown, Button467.MouseDown, Button466.MouseDown, Button465.MouseDown, Button464.MouseDown, Button463.MouseDown, Button462.MouseDown, Button461.MouseDown, Button460.MouseDown, Button459.MouseDown, Button458.MouseDown, Button457.MouseDown, Button456.MouseDown, Button455.MouseDown, Button454.MouseDown, Button453.MouseDown, Button452.MouseDown, Button451.MouseDown, Button450.MouseDown, Button449.MouseDown, Button448.MouseDown, Button447.MouseDown, Button446.MouseDown, Button445.MouseDown, Button444.MouseDown, Button443.MouseDown, Button442.MouseDown, Button441.MouseDown, Button440.MouseDown, Button439.MouseDown, Button438.MouseDown, Button437.MouseDown, Button436.MouseDown, Button435.MouseDown, Button434.MouseDown, Button433.MouseDown, Button432.MouseDown, Button431.MouseDown, Button430.MouseDown, Button429.MouseDown, Button428.MouseDown, Button427.MouseDown, Button426.MouseDown, Button425.MouseDown, Button424.MouseDown, Button423.MouseDown, Button422.MouseDown, Button421.MouseDown, Button420.MouseDown, Button419.MouseDown, Button418.MouseDown, Button417.MouseDown, Button416.MouseDown, Button415.MouseDown, Button414.MouseDown, Button413.MouseDown, Button412.MouseDown, Button411.MouseDown, Button410.MouseDown, Button409.MouseDown, Button408.MouseDown, Button407.MouseDown, Button406.MouseDown, Button405.MouseDown, Button404.MouseDown, Button403.MouseDown, Button402.MouseDown, Button401.MouseDown, Button1430.MouseDown, Button1429.MouseDown, Button1428.MouseDown, Button1427.MouseDown, Button1426.MouseDown, Button1425.MouseDown, Button1424.MouseDown, Button1423.MouseDown, Button1422.MouseDown, Button1421.MouseDown, Button1420.MouseDown, Button1419.MouseDown, Button1418.MouseDown, Button1417.MouseDown, Button1416.MouseDown, Button1415.MouseDown, Button1414.MouseDown, Button1413.MouseDown, Button1412.MouseDown, Button1411.MouseDown, Button1410.MouseDown, Button1409.MouseDown, Button1408.MouseDown, Button1407.MouseDown, Button1406.MouseDown, Button1405.MouseDown, Button1404.MouseDown, Button1403.MouseDown, Button1402.MouseDown, Button1401.MouseDown, Button1400.MouseDown, Button1399.MouseDown, Button1398.MouseDown, Button1397.MouseDown, Button1396.MouseDown, Button1395.MouseDown, Button1394.MouseDown, Button1393.MouseDown, Button1392.MouseDown, Button1391.MouseDown, Button1390.MouseDown, Button1389.MouseDown, Button1388.MouseDown, Button1387.MouseDown, Button1386.MouseDown, Button1385.MouseDown, Button1384.MouseDown, Button1383.MouseDown, Button1382.MouseDown, Button1381.MouseDown, Button1380.MouseDown, Button1379.MouseDown, Button1378.MouseDown, Button1377.MouseDown, Button1376.MouseDown, Button1375.MouseDown, Button1374.MouseDown, Button1373.MouseDown, Button1372.MouseDown, Button1371.MouseDown, Button1370.MouseDown, Button1369.MouseDown, Button1368.MouseDown, Button1367.MouseDown, Button1366.MouseDown, Button1365.MouseDown, Button1364.MouseDown, Button1363.MouseDown, Button1362.MouseDown, Button1361.MouseDown, Button1360.MouseDown, Button1359.MouseDown, Button1358.MouseDown, Button1357.MouseDown, Button1356.MouseDown, Button1355.MouseDown, Button1354.MouseDown, Button1353.MouseDown, Button1352.MouseDown, Button1351.MouseDown, Button1350.MouseDown, Button1349.MouseDown, Button1348.MouseDown, Button1347.MouseDown, Button1346.MouseDown, Button1345.MouseDown, Button1344.MouseDown, Button1343.MouseDown, Button1342.MouseDown, Button1341.MouseDown, Button1340.MouseDown, Button1339.MouseDown, Button1338.MouseDown, Button1337.MouseDown, Button1336.MouseDown, Button1335.MouseDown, Button1334.MouseDown, Button1333.MouseDown, Button1332.MouseDown, Button1331.MouseDown, Button1330.MouseDown, Button1329.MouseDown, Button1328.MouseDown, Button1327.MouseDown, Button1326.MouseDown, Button1325.MouseDown, Button1324.MouseDown, Button1323.MouseDown, Button1322.MouseDown, Button1321.MouseDown, Button1320.MouseDown, Button1319.MouseDown, Button1318.MouseDown, Button1317.MouseDown, Button1316.MouseDown, Button1315.MouseDown, Button1314.MouseDown, Button1313.MouseDown, Button1312.MouseDown, Button1311.MouseDown, Button1310.MouseDown, Button1309.MouseDown, Button1308.MouseDown, Button1307.MouseDown, Button1306.MouseDown, Button1305.MouseDown, Button1304.MouseDown, Button1303.MouseDown, Button1302.MouseDown, Button1301.MouseDown, Button1300.MouseDown, Button1299.MouseDown, Button1298.MouseDown, Button1297.MouseDown, Button1296.MouseDown, Button1295.MouseDown, Button1294.MouseDown, Button1293.MouseDown, Button1292.MouseDown, Button1291.MouseDown, Button1290.MouseDown, Button1289.MouseDown, Button1288.MouseDown, Button1287.MouseDown, Button1286.MouseDown, Button1285.MouseDown, Button1284.MouseDown, Button1283.MouseDown, Button1282.MouseDown, Button1281.MouseDown, Button1280.MouseDown, Button1279.MouseDown, Button1278.MouseDown, Button1277.MouseDown, Button1276.MouseDown, Button1275.MouseDown, Button1274.MouseDown, Button1273.MouseDown, Button1272.MouseDown, Button1271.MouseDown, Button1270.MouseDown, Button1269.MouseDown, Button1268.MouseDown, Button1267.MouseDown, Button1266.MouseDown, Button1265.MouseDown, Button1264.MouseDown, Button1263.MouseDown, Button1262.MouseDown, Button1261.MouseDown, Button1260.MouseDown, Button1259.MouseDown, Button1258.MouseDown, Button1257.MouseDown, Button1256.MouseDown, Button1255.MouseDown, Button1254.MouseDown, Button1253.MouseDown, Button1252.MouseDown, Button1251.MouseDown, Button1250.MouseDown, Button1249.MouseDown, Button1248.MouseDown, Button1247.MouseDown, Button1246.MouseDown, Button1245.MouseDown, Button1244.MouseDown, Button1243.MouseDown, Button1242.MouseDown, Button1241.MouseDown, Button1240.MouseDown, Button1239.MouseDown, Button1238.MouseDown, Button1237.MouseDown, Button1236.MouseDown, Button1235.MouseDown, Button1234.MouseDown, Button1233.MouseDown, Button1232.MouseDown, Button1231.MouseDown, Button1230.MouseDown, Button1229.MouseDown, Button1228.MouseDown, Button1227.MouseDown, Button1226.MouseDown, Button1225.MouseDown, Button1224.MouseDown, Button1223.MouseDown, Button1222.MouseDown, Button1221.MouseDown, Button1220.MouseDown, Button1219.MouseDown, Button1218.MouseDown, Button1217.MouseDown, Button1216.MouseDown, Button1215.MouseDown, Button1214.MouseDown, Button1213.MouseDown, Button1212.MouseDown, Button1211.MouseDown, Button1210.MouseDown, Button1209.MouseDown, Button1208.MouseDown, Button1207.MouseDown, Button1206.MouseDown, Button1205.MouseDown, Button1204.MouseDown, Button1203.MouseDown, Button1202.MouseDown, Button1201.MouseDown, Button1200.MouseDown, Button1199.MouseDown, Button1198.MouseDown, Button1197.MouseDown, Button1196.MouseDown, Button1195.MouseDown, Button1194.MouseDown, Button1193.MouseDown, Button1192.MouseDown, Button1191.MouseDown, Button1190.MouseDown, Button1189.MouseDown, Button1188.MouseDown, Button1187.MouseDown, Button1186.MouseDown, Button1185.MouseDown, Button1184.MouseDown, Button1183.MouseDown, Button1182.MouseDown, Button1181.MouseDown, Button1180.MouseDown, Button1179.MouseDown, Button1178.MouseDown, Button1177.MouseDown, Button1176.MouseDown, Button1175.MouseDown, Button1174.MouseDown, Button1173.MouseDown, Button1172.MouseDown, Button1171.MouseDown, Button1170.MouseDown, Button1169.MouseDown, Button1168.MouseDown, Button1167.MouseDown, Button1166.MouseDown, Button1165.MouseDown, Button1164.MouseDown, Button1163.MouseDown, Button1162.MouseDown, Button1161.MouseDown, Button1160.MouseDown, Button1159.MouseDown, Button1158.MouseDown, Button1157.MouseDown, Button1156.MouseDown, Button1155.MouseDown, Button1154.MouseDown, Button1153.MouseDown, Button1152.MouseDown, Button1151.MouseDown, Button1150.MouseDown, Button1149.MouseDown, Button1148.MouseDown, Button1147.MouseDown, Button1146.MouseDown, Button1145.MouseDown, Button1144.MouseDown, Button1143.MouseDown, Button1142.MouseDown, Button1141.MouseDown, Button1140.MouseDown, Button1139.MouseDown, Button1138.MouseDown, Button1137.MouseDown, Button1136.MouseDown, Button1135.MouseDown, Button1134.MouseDown, Button1133.MouseDown, Button1132.MouseDown, Button1131.MouseDown, Button1130.MouseDown, Button1129.MouseDown, Button1128.MouseDown, Button1127.MouseDown, Button1126.MouseDown, Button1125.MouseDown, Button1124.MouseDown, Button1123.MouseDown, Button1122.MouseDown, Button1121.MouseDown, Button1120.MouseDown, Button1119.MouseDown, Button1118.MouseDown, Button1117.MouseDown, Button1116.MouseDown, Button1115.MouseDown, Button1114.MouseDown, Button1113.MouseDown, Button1112.MouseDown, Button1111.MouseDown, Button1110.MouseDown, Button1109.MouseDown, Button1108.MouseDown, Button1107.MouseDown, Button1106.MouseDown, Button1105.MouseDown, Button1104.MouseDown, Button1103.MouseDown, Button1102.MouseDown, Button1101.MouseDown, Button1100.MouseDown, Button1099.MouseDown, Button1098.MouseDown, Button1097.MouseDown, Button1096.MouseDown, Button1095.MouseDown, Button1094.MouseDown, Button1093.MouseDown, Button1092.MouseDown, Button1091.MouseDown, Button1090.MouseDown, Button1089.MouseDown, Button1088.MouseDown, Button1087.MouseDown, Button1086.MouseDown, Button1085.MouseDown, Button1084.MouseDown, Button1083.MouseDown, Button1082.MouseDown, Button1081.MouseDown, Button1080.MouseDown, Button1079.MouseDown, Button1078.MouseDown, Button1077.MouseDown, Button1076.MouseDown, Button1075.MouseDown, Button1074.MouseDown, Button1073.MouseDown, Button1072.MouseDown, Button1071.MouseDown, Button1070.MouseDown, Button1069.MouseDown, Button1068.MouseDown, Button1067.MouseDown, Button1066.MouseDown, Button1065.MouseDown, Button1064.MouseDown, Button1063.MouseDown, Button1062.MouseDown, Button1061.MouseDown, Button1060.MouseDown, Button1059.MouseDown, Button1058.MouseDown, Button1057.MouseDown, Button1056.MouseDown, Button1055.MouseDown, Button1054.MouseDown, Button1053.MouseDown, Button1052.MouseDown, Button1051.MouseDown, Button1050.MouseDown, Button1049.MouseDown, Button1048.MouseDown, Button1047.MouseDown, Button1046.MouseDown, Button1045.MouseDown, Button1044.MouseDown, Button1043.MouseDown, Button1042.MouseDown, Button1041.MouseDown, Button1040.MouseDown, Button1039.MouseDown, Button1038.MouseDown, Button1037.MouseDown, Button1036.MouseDown, Button1035.MouseDown, Button1034.MouseDown, Button1033.MouseDown, Button1032.MouseDown, Button1031.MouseDown, Button1030.MouseDown, Button1029.MouseDown, Button1028.MouseDown, Button1027.MouseDown, Button1026.MouseDown, Button1025.MouseDown, Button1024.MouseDown, Button1023.MouseDown, Button1022.MouseDown, Button1021.MouseDown, Button1020.MouseDown, Button1019.MouseDown, Button1018.MouseDown, Button1017.MouseDown, Button1016.MouseDown, Button1015.MouseDown, Button1014.MouseDown, Button1013.MouseDown, Button1012.MouseDown, Button1011.MouseDown, Button1010.MouseDown, Button1009.MouseDown, Button1008.MouseDown, Button1007.MouseDown, Button1006.MouseDown, Button1005.MouseDown, Button1004.MouseDown, Button1003.MouseDown, Button1002.MouseDown, Button1001.MouseDown, Button1000.MouseDown
        Dim btn As Button = DirectCast(sender, Button)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Not btn.BackgroundImage Is b_flag.BackgroundImage Then
                btn.BackColor = Drawing.Color.LightGray
                If first_click = True Then
                    b_code = btn
                    Deploy_Mines()
                    Timer1.Start()
                    Timer2.Start()
                    Timer3.Start()
                    NumbersToolStripMenuItem.Enabled = False
                    first_click = False
                End If
                btn_check = btn
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            If Not btn.BackColor = Drawing.Color.LightGray Then
                If Not btn.BackgroundImage Is b_flag.BackgroundImage Then
                    btn.BackgroundImage = b_flag.BackgroundImage
                    btn.FlatStyle = FlatStyle.Flat
                    btn.FlatAppearance.BorderColor = clr_code
                    btn.BackColor = Drawing.Color.Orange
                    TextBox1.Text -= 1
                Else
                    btn.BackgroundImage = non_image.BackgroundImage
                    btn.FlatStyle = FlatStyle.Popup
                    btn.FlatAppearance.BorderColor = Drawing.Color.Black
                    btn.BackColor = clr_code
                    TextBox1.Text += 1
                End If
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        For Each Obj As Object In Me.Controls
            If Obj.GetType Is GetType(Button) Then
                If Not DirectCast(Obj, Button).Name = "b_image" Then
                    If Not DirectCast(Obj, Button).Name = "non_image" Then
                        If Not DirectCast(Obj, Button).Name = "b_flag" Then
                            If DirectCast(Obj, Button).Name = btn_check.Name Then
                                If has_mine(b_completed) = True Then
                                    Timer1.Stop()
                                    Timer2.Stop()
                                    Timer3.Stop()
                                    DirectCast(Obj, Button).BackgroundImage = b_image.BackgroundImage
                                    MsgBox("You Lose!", MsgBoxStyle.OkOnly, "Minesweeper")
                                    game_over()
                                Else
                                    b_num(btn_check)
                                End If
                            End If
                            b_completed += 1
                        End If
                    End If
                End If
            End If
        Next
        b_completed = 0
    End Sub

    Sub b_num(ByVal btn As Button)
        Dim num As Integer = 0
        b_completed = 0
        For Each Obj As Object In Me.Controls
            If Obj.GetType Is GetType(Button) Then
                If Not DirectCast(Obj, Button).Name = "b_image" Then
                    If Not DirectCast(Obj, Button).Name = "non_image" Then
                        If Not DirectCast(Obj, Button).Name = "b_flag" Then
                            If Not DirectCast(Obj, Button).Name = btn.Name Then
                                If btn.Bounds.IntersectsWith(DirectCast(Obj, Button).Bounds) Then
                                    If has_mine(b_completed) = True Then
                                        num += 1
                                    End If
                                End If
                            End If
                            b_completed += 1
                        End If
                    End If
                End If
            End If
        Next
        b_completed = 0
        If Not num = 0 Then
            btn.Text = num
            If num = 1 Then
                btn.ForeColor = num_clr(0)
            ElseIf num = 2 Then
                btn.ForeColor = num_clr(1)
            ElseIf num = 3 Then
                btn.ForeColor = num_clr(2)
            ElseIf num = 4 Then
                btn.ForeColor = num_clr(3)
            ElseIf num = 5 Then
                btn.ForeColor = num_clr(4)
            ElseIf num = 6 Then
                btn.ForeColor = num_clr(5)
            ElseIf num = 7 Then
                btn.ForeColor = num_clr(6)
            ElseIf num = 8 Then
                btn.ForeColor = num_clr(7)
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim check As Integer = 0
        b_completed = 0
        For Each obj As Object In Me.Controls
            If obj.GetType Is GetType(Button) Then
                If Not DirectCast(obj, Button).Name = "b_image" Then
                    If Not DirectCast(obj, Button).Name = "non_image" Then
                        If Not DirectCast(obj, Button).Name = "b_flag" Then
                            If has_mine(b_completed) = False Then
                                If DirectCast(obj, Button).BackColor = clr_code Then
                                    check += 1
                                End If
                            End If
                            b_completed += 1
                        End If
                    End If
                End If
            End If
        Next
        b_completed = 0
        If check = 0 Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            MsgBox("You Win!", MsgBoxStyle.OkOnly, "Minesweeper")
            game_won()
        End If
        check = 0
    End Sub

    Sub game_over()
        b_completed = 0
        For Each Obj As Object In Me.Controls
            If Obj.GetType Is GetType(Button) Then
                If Not DirectCast(Obj, Button).Name = "b_image" Then
                    If Not DirectCast(Obj, Button).Name = "non_image" Then
                        If Not DirectCast(Obj, Button).Name = "b_flag" Then
                            If has_mine(b_completed) = True Then
                                If Not DirectCast(Obj, Button).BackgroundImage Is b_flag.BackgroundImage Then
                                    DirectCast(Obj, Button).BackgroundImage = b_image.BackgroundImage
                                End If
                            End If
                            If DirectCast(Obj, Button).BackColor = clr_code Then
                                DirectCast(Obj, Button).Enabled = False
                            ElseIf DirectCast(Obj, Button).BackgroundImage Is b_flag.BackgroundImage Then
                                DirectCast(Obj, Button).Enabled = False
                            End If
                            b_completed += 1
                        End If
                    End If
                End If
            End If
        Next
        b_completed = 0
        My.Settings.tot += 1
        My.Settings.lose += 1
    End Sub

    Sub game_won()
        b_completed = 0
        For Each Obj As Object In Me.Controls
            If Obj.GetType Is GetType(Button) Then
                If DirectCast(Obj, Button).Enabled = True Then
                    If Not DirectCast(Obj, Button).Name = "b_image" Then
                        If Not DirectCast(Obj, Button).Name = "non_image" Then
                            If Not DirectCast(Obj, Button).Name = "b_flag" Then
                                If DirectCast(Obj, Button).BackColor = clr_code Then
                                    DirectCast(Obj, Button).Enabled = False
                                ElseIf DirectCast(Obj, Button).BackgroundImage Is b_flag.BackgroundImage Then
                                    DirectCast(Obj, Button).Enabled = False
                                End If
                                b_completed += 1
                            End If
                        End If
                    End If
                End If
            End If
        Next
        b_completed = 0
        My.Settings.tot += 1
        My.Settings.win += 1
        If My.Settings.first = True Then
            My.Settings.first = False
            My.Settings.time = TextBox2.Text
        Else
            If My.Settings.time > TextBox2.Text Then
                My.Settings.time = TextBox2.Text
            End If
        End If
    End Sub

    Sub Deploy_Mines()
this:   new_mines()
        If mines < minimum_mines Then
            mines = 0
            b_completed = 0
            GoTo this
        End If
        b_completed = 0
        TextBox1.Text = mines
    End Sub

    Sub new_mines()
        discard()
        b_completed = 0
        For Each obj As Object In Me.Controls
            If obj.GetType Is GetType(Button) Then
                If Not DirectCast(obj, Button).Name = "b_image" Then
                    If Not DirectCast(obj, Button).Name = "non_image" Then
                        If Not DirectCast(obj, Button).Name = "b_flag" Then
                            Dim r As Integer = CInt(Int(8 * Rnd()) + 0)
                            If r = 4 Then
                                If Not DirectCast(obj, Button).Name = b_code.Name Then
                                    has_mine(b_completed) = True
                                    mines += 1
                                Else
                                    has_mine(b_completed) = False
                                End If
                            Else
                                has_mine(b_completed) = False
                            End If
                            b_completed += 1
                        End If
                    End If
                End If
            End If
        Next
        b_completed = 0
    End Sub

    Sub color(ByVal clr As System.Drawing.Color)
        For Each Obj As Object In Me.Controls
            If Obj.GetType Is GetType(Button) Then
                If DirectCast(Obj, Button).BackColor = clr_code Then
                    DirectCast(Obj, Button).BackColor = clr
                End If
            End If
        Next
    End Sub

    Sub discard()
        Dim i As Integer
        For i = 0 To 2399
            If has_mine(i) = True Then
                has_mine(i) = False
            End If
        Next
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        Timer3.Stop()
        Timer2.Stop()
        Timer1.Stop()
        TextBox2.Text = 0
        TextBox1.Text = 0
        first_click = True
        purple = False
        mines = 0
        b_completed = 0
        NumbersToolStripMenuItem.Enabled = True
        For Each Obj As Object In Me.Controls
            If Obj.GetType Is GetType(Button) Then
                If Not DirectCast(Obj, Button).Name = "b_image" Then
                    If Not DirectCast(Obj, Button).Name = "non_image" Then
                        If Not DirectCast(Obj, Button).Name = "b_flag" Then
                            DirectCast(Obj, Button).Enabled = True
                            DirectCast(Obj, Button).BackColor = clr_code
                            DirectCast(Obj, Button).Text = ""
                            DirectCast(Obj, Button).FlatStyle = FlatStyle.Popup
                            DirectCast(Obj, Button).BackgroundImage = non_image.BackgroundImage
                        End If
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Game Created By Rachit Dhar. Project Started On March 15, 2016 And Game Completed Fully By March 28, 2016. Enjoy!", MsgBoxStyle.OkOnly, "Minesweeper")
    End Sub

    Private Sub HowToPlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToPlayToolStripMenuItem.Click
        MsgBox("Minesweeper is a well known and a very famous Game. It Consists of Squares that are to be clicked. Under the Squares are either Numbers From 1 to 8 or Mines which when clicked would Explode and You Will Lose. The Numbers Indicate How Many Mines Are Around that Square and this Allows You To Pridict the Correct Squares. One who manages to click all the Safe Squares will Win!", MsgBoxStyle.OkOnly, "Minesweeper")
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        color(Drawing.Color.DodgerBlue)
        clr_code = Drawing.Color.DodgerBlue
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        color(Drawing.Color.Green)
        clr_code = Drawing.Color.Green
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        color(Drawing.Color.Red)
        clr_code = Drawing.Color.Red
    End Sub

    Private Sub YellowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem.Click
        color(Drawing.Color.Yellow)
        clr_code = Drawing.Color.Yellow
    End Sub

    Private Sub OriginalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OriginalToolStripMenuItem.Click
        color(Drawing.Color.FromArgb(160, 160, 160, 160))
        clr_code = Drawing.Color.FromArgb(160, 160, 160, 160)
    End Sub

    Private Sub RecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordsToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub HighScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighScoreToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub OriginalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OriginalToolStripMenuItem1.Click
        num_clr(0) = Drawing.Color.Blue
        num_clr(1) = Drawing.Color.Green
        num_clr(2) = Drawing.Color.Red
        num_clr(3) = Drawing.Color.DarkBlue
        num_clr(4) = Drawing.Color.Maroon
        num_clr(5) = Drawing.Color.LightSeaGreen
        num_clr(6) = Drawing.Color.Black
        num_clr(7) = Drawing.Color.Gray
    End Sub

    Private Sub ClassicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassicToolStripMenuItem.Click
        num_clr(0) = Drawing.Color.Black
        num_clr(1) = Drawing.Color.Gray
        num_clr(2) = Drawing.Color.Orange
        num_clr(3) = Drawing.Color.Green
        num_clr(4) = Drawing.Color.Blue
        num_clr(5) = Drawing.Color.Red
        num_clr(6) = Drawing.Color.Yellow
        num_clr(7) = Drawing.Color.Maroon
    End Sub

    Private Sub Special1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Special1ToolStripMenuItem.Click
        num_clr(0) = Drawing.Color.Orange
        num_clr(1) = Drawing.Color.HotPink
        num_clr(2) = Drawing.Color.Purple
        num_clr(3) = Drawing.Color.SeaGreen
        num_clr(4) = Drawing.Color.Red
        num_clr(5) = Drawing.Color.Blue
        num_clr(6) = Drawing.Color.White
        num_clr(7) = Drawing.Color.Black
    End Sub

    Private Sub CheatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheatToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub StopCheatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopCheatToolStripMenuItem.Click
        For Each Obj As Object In Me.Controls
            If Obj.GetType Is GetType(Button) Then
                If Not DirectCast(Obj, Button).Name = "b_image" Then
                    If Not DirectCast(Obj, Button).Name = "non_image" Then
                        If Not DirectCast(Obj, Button).Name = "b_flag" Then
                            If DirectCast(Obj, Button).BackColor = Drawing.Color.Purple Then
                                DirectCast(Obj, Button).BackColor = clr_code
                            End If
                        End If
                    End If
                End If
            End If
        Next
        My.Settings.check = False
        purple = False
    End Sub
End Class