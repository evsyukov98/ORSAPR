using Kompas6API5;
using Kompas6Constants3D;
using System;

namespace KompasGorka
{
    class Builder
    {
        public FigureParams FigureParams;
        public ksPart iPart;


        public void Build(ksPart iPart, FigureParams figureParams)
        {
            FigureParams = figureParams;
            this.iPart = iPart;

            CreatePlatform();

            CreateStartSlide();

            CreateSlide();

            CreateEndSlide();

            CreateBorder();

            CreatePillar();

            CreateStairsBorder();
           
        }
        
        // С комментариями
        private void CreatePlatform()
        {
            ksEntity iSketch;

            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);


            // Интерфейс для рисования = на скетче;
            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            // Построить линию (x1,y1, x2,y2, style)
            iDocument2D.ksLineSeg(0, 0, 0, 3, 1);
            iDocument2D.ksLineSeg(0, 3, FigureParams.PlatformLengthF, 3, 1);
            iDocument2D.ksLineSeg(FigureParams.PlatformLengthF, 3, FigureParams.PlatformLengthF, 0, 1);
            iDocument2D.ksLineSeg(FigureParams.PlatformLengthF, 0, 0, 0, 1);

            // Закончить редактировать эскиз
            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, FigureParams.SlideWidthA, true);
        }

        private void CreateStartSlide()
        {
            ksEntity iSketch;

            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);


            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(FigureParams.PlatformLengthF , 0, 
                FigureParams.PlatformLengthF , 3, 1);

            iDocument2D.ksLineSeg(FigureParams.PlatformLengthF , 3, 
                FigureParams.PlatformLengthF  +FigureParams.StartLengthE, 3, 1);

            iDocument2D.ksLineSeg(FigureParams.PlatformLengthF  + FigureParams.StartLengthE, 3,
                FigureParams.PlatformLengthF  + FigureParams.StartLengthE, 0, 1);

            iDocument2D.ksLineSeg(FigureParams.PlatformLengthF  + FigureParams.StartLengthE, 0,
                FigureParams.PlatformLengthF , 0, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, FigureParams.SlideWidthA, true);
        }

        private void CreateSlide()
        {
            ksEntity iSketch;

            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);


            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(FigureParams.PlatformLengthF +FigureParams.StartLengthE , 0,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE, 3, 1);

            iDocument2D.ksLineSeg(FigureParams.PlatformLengthF + FigureParams.StartLengthE, 3,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE +FigureParams.MainLengthL, 
                FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL,
                FigureParams.PlatformHeightG,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL,
                FigureParams.PlatformHeightG - 3, 1);

            iDocument2D.ksLineSeg(
                 FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL, 
                 FigureParams.PlatformHeightG - 3,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE , 0, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, FigureParams.SlideWidthA, true);
        }

        private void CreateEndSlide()
        {
            ksEntity iSketch;

            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);


            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(
                FigureParams.PlatformLengthF + FigureParams.StartLengthE+ FigureParams.MainLengthL, 
                FigureParams.PlatformHeightG - 3,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL,
                FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL,
                FigureParams.PlatformHeightG,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL + FigureParams.EndLengthD,
                FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL +FigureParams.EndLengthD,
                FigureParams.PlatformHeightG,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL +FigureParams.EndLengthD,
                FigureParams.PlatformHeightG - 3, 1);

            iDocument2D.ksLineSeg(
                 FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL + FigureParams.EndLengthD,
                 FigureParams.PlatformHeightG - 3,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE+FigureParams.MainLengthL,
                FigureParams.PlatformHeightG - 3, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, FigureParams.SlideWidthA, true);
        }

        private void CreateBorder()
        {
            ksEntity iSketch;
            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);


            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(
                FigureParams.PlatformLengthF, 
                -FigureParams.BorderHightC, 
                FigureParams.PlatformLengthF + FigureParams.StartLengthE, 
                -FigureParams.BorderHightC, 1);

            iDocument2D.ksLineSeg(
                FigureParams.PlatformLengthF + FigureParams.StartLengthE,
                -FigureParams.BorderHightC,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE +FigureParams.MainLengthL, 
                FigureParams.PlatformHeightG -3 - FigureParams.BorderHightC, 1);

            iDocument2D.ksLineSeg(
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL,
                FigureParams.PlatformHeightG - 3 - FigureParams.BorderHightC,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL +FigureParams.EndLengthD,
                FigureParams.PlatformHeightG - 3 - FigureParams.BorderHightC, 1);

            iDocument2D.ksLineSeg(
                 FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL + FigureParams.EndLengthD,
                FigureParams.PlatformHeightG - 3 - FigureParams.BorderHightC,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL + FigureParams.EndLengthD,
                FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(
                 FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL + FigureParams.EndLengthD,
                FigureParams.PlatformHeightG,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL,
                FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(
                 FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL,
                FigureParams.PlatformHeightG,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE,
                3, 1);

            iDocument2D.ksLineSeg(
                 FigureParams.PlatformLengthF + FigureParams.StartLengthE,
                3,
                FigureParams.PlatformLengthF,
                3, 1);

            iDocument2D.ksLineSeg(
                 FigureParams.PlatformLengthF,
                3,
                FigureParams.PlatformLengthF,
                -FigureParams.BorderHightC, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, 2, false);

            CreateSketch(out iSketch, out iDefinitionSketch, FigureParams.SlideWidthA);


            iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(
                FigureParams.PlatformLengthF,
                -FigureParams.BorderHightC,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE,
                -FigureParams.BorderHightC, 1);

            iDocument2D.ksLineSeg(
                FigureParams.PlatformLengthF + FigureParams.StartLengthE,
                -FigureParams.BorderHightC,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL,
                FigureParams.PlatformHeightG - 3 - FigureParams.BorderHightC, 1);

            iDocument2D.ksLineSeg(
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL,
                FigureParams.PlatformHeightG - 3 - FigureParams.BorderHightC,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL + FigureParams.EndLengthD,
                FigureParams.PlatformHeightG - 3 - FigureParams.BorderHightC, 1);

            iDocument2D.ksLineSeg(
                 FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL + FigureParams.EndLengthD,
                FigureParams.PlatformHeightG - 3 - FigureParams.BorderHightC,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL + FigureParams.EndLengthD,
                FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(
                 FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL + FigureParams.EndLengthD,
                FigureParams.PlatformHeightG,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL,
                FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(
                 FigureParams.PlatformLengthF + FigureParams.StartLengthE + FigureParams.MainLengthL,
                FigureParams.PlatformHeightG,
                FigureParams.PlatformLengthF + FigureParams.StartLengthE,
                3, 1);

            iDocument2D.ksLineSeg(
                 FigureParams.PlatformLengthF + FigureParams.StartLengthE,
                3,
                FigureParams.PlatformLengthF,
                3, 1);

            iDocument2D.ksLineSeg(
                 FigureParams.PlatformLengthF,
                3,
                FigureParams.PlatformLengthF,
                -FigureParams.BorderHightC, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, 2, true);
        }

        private void CreatePillar()
        {
            ksEntity iSketch;
            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();
            
            iDocument2D.ksLineSeg(0, -50, 5, -50, 1);

            iDocument2D.ksLineSeg(5, -50, 5, FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(5, FigureParams.PlatformHeightG, 0, FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(0,FigureParams.PlatformHeightG, 0, -50, 1);


            iDocument2D.ksLineSeg(0 + FigureParams.PlatformLengthF, -50, 5 + FigureParams.PlatformLengthF, -50, 1);

            iDocument2D.ksLineSeg(5 + FigureParams.PlatformLengthF, -50, 5 + FigureParams.PlatformLengthF, FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(5 + FigureParams.PlatformLengthF, FigureParams.PlatformHeightG, 0 + FigureParams.PlatformLengthF, FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(0 + FigureParams.PlatformLengthF, FigureParams.PlatformHeightG, 0 + FigureParams.PlatformLengthF, -50, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, 5, false);

            CreateSketch(out iSketch, out iDefinitionSketch, FigureParams.SlideWidthA);

            iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(0, -50, 5, -50, 1);

            iDocument2D.ksLineSeg(5, -50, 5, FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(5, FigureParams.PlatformHeightG, 0, FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(0, FigureParams.PlatformHeightG, 0, -50, 1);


            iDocument2D.ksLineSeg(0 + FigureParams.PlatformLengthF, -50, 5 + FigureParams.PlatformLengthF, -50, 1);

            iDocument2D.ksLineSeg(5 + FigureParams.PlatformLengthF, -50, 5 + FigureParams.PlatformLengthF, FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(5 + FigureParams.PlatformLengthF, FigureParams.PlatformHeightG, 0 + FigureParams.PlatformLengthF, FigureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(0 + FigureParams.PlatformLengthF, FigureParams.PlatformHeightG, 0 + FigureParams.PlatformLengthF, -50, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, 5, true);




        }

        private void CreateStairsBorder()
        {
            ksEntity iSketch;
            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(0, 0, 0, -15 , 1);
            iDocument2D.ksLineSeg(0, -15, -100, FigureParams.PlatformHeightG - 15, 1);

            iDocument2D.ksLineSeg(-100, FigureParams.PlatformHeightG -15, -100, FigureParams.PlatformHeightG, 1);
            iDocument2D.ksLineSeg(-100, FigureParams.PlatformHeightG , 0, 0, 1);


            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, 2, false);

            CreateSketch(out iSketch, out iDefinitionSketch, FigureParams.SlideWidthA);

            iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(0,0, 0, -15, 1);
            iDocument2D.ksLineSeg(0, -15 , -100, FigureParams.PlatformHeightG - 15, 1);

            iDocument2D.ksLineSeg(-100, FigureParams.PlatformHeightG - 15, -100, FigureParams.PlatformHeightG, 1);
            iDocument2D.ksLineSeg(-100, FigureParams.PlatformHeightG, 0, 0, 1);


            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, 2, true);
        }


        /// <summary>
        /// Создать эскиз
        /// </summary>
        /// <param name="iSketch">Эскиз</param>
        /// <param name="iDefinitionSketch">Определение эскиза</param>
        /// <param name="offset">Смещение от начальной плоскости</param>
        private void CreateSketch(out ksEntity iSketch, out ksSketchDefinition iDefinitionSketch, double offset = 0)
        {
            #region Создание смещенную плоскость -------------------------
            // интерфейс смещенной плоскости
            ksEntity iPlane = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_planeOffset);

            // Получаем интрефейс настроек смещенной плоскости
            ksPlaneOffsetDefinition iPlaneDefinition = (ksPlaneOffsetDefinition)iPlane.GetDefinition();

            // Настройки : начальная позиция, направление смещения, расстояние от плоскости, принять все настройки (create)
            iPlaneDefinition.SetPlane(iPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ));
            iPlaneDefinition.direction = true;
            iPlaneDefinition.offset = offset;
            iPlane.Create();
            #endregion --------------------------------------------------

            // Создаем обьект эскиза
            iSketch = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_sketch);

            // Получаем интерфейс настроек эскиза
            iDefinitionSketch = iSketch.GetDefinition();

            // Устанавливаем плоскость эскиза
            iDefinitionSketch.SetPlane(iPlane);

            // Теперь когда св-ва эскиза установлены можно его создать 
            iSketch.Create();
        }

        /// <summary>
        /// Выдавливание по эскизу
        /// </summary>
        /// <param name="iPart">Интерфейс детали</param>
        /// <param name="iSketch">Эскиз</param>
        /// <param name="depth">Глубина выдавливания</param>
        /// <param name="direction">Направление выдавливания</param>
        private void ExctrusionSketch(ksPart iPart, ksEntity iSketch, double depth, bool direction)
        {
            //Операция выдавливание
            ksEntity entityExtr = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_bossExtrusion);

            //Интерфейс операции выдавливания
            ksBossExtrusionDefinition extrusionDef = (ksBossExtrusionDefinition)entityExtr.GetDefinition();

            //Интерфейс структуры параметров выдавливания
            ksExtrusionParam extrProp = (ksExtrusionParam)extrusionDef.ExtrusionParam();

            //Эскиз операции выдавливания
            extrusionDef.SetSketch(iSketch);

            //Направление выдавливания
            if (direction == false)
            {
                extrProp.direction = (short)Direction_Type.dtReverse;
            }
            else
            {
                extrProp.direction = (short)Direction_Type.dtNormal;
            }

            //Тип выдавливания
            extrProp.typeNormal = (short)End_Type.etBlind;

            //Глубина выдавливания
            if (direction == false)
            {
                extrProp.depthReverse = depth;
            }
            else
            {
                extrProp.depthNormal = depth;
            }

            //Создание операции
            entityExtr.Create();
        }

        /* 
        // Построить коробку на поверхности другой (пока не работает)
        private void CreateCaseFace(ksPart iPart)
        {
            // Создаем обьект эскиза 
            ksEntity iSketch = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_sketch);

            // Получаем интерфейс свойств эскиза
            ksSketchDefinition iDefinitionSketch = iSketch.GetDefinition();

            ksEntityCollection iCollection =
                (ksEntityCollection)iPart.EntityCollection((short)Obj3dType.o3d_face);

            #region очевидно что гдето здесь не может выбрать обьект 

            iCollection.SelectByPoint(1, 1.8f, 1.8f);

            // Устанавливаем плоскость эскиза на поверхности другой
            iDefinitionSketch.SetPlane((ksEntity)iCollection.First());

            #endregion

            // Теперь когда св-ва эскиза установлены можно его создать 
            iSketch.Create();

            // Берем у эскиза св-ва для черчений линий
            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            // Построить линию (x1,y1, x2,y2, style)
            iDocument2D.ksLineSeg(1, 2, 3, 3, 1);

            // Закончить редактировать эскиз
            iDefinitionSketch.EndEdit();
        }*/
    }
}
