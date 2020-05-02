using Kompas6API5;
using Kompas6Constants3D;
using KompasGorka.Model;

namespace KompasGorka.API
{
    /// <summary>
    /// Класс для построения фигуры.
    /// </summary>
    public class Builder
    {
        /// <summary>
        /// Параметры фигуры.
        /// </summary>
        private FigureParams _figureParams;

        /// <summary>
        /// Интерфейс компонента.
        /// </summary>
        private ksPart _iPart;
        
        /// <summary>
        /// Построить всю горку.
        /// </summary>
        /// <param name="iPart"></param>
        /// <param name="figureParams"></param>
        public void Build(ksPart iPart, FigureParams figureParams)
        {
            _figureParams = figureParams;

            _iPart = iPart;

            // Толщина горки
            const int slideThickness = 4;

            CreatePlatform();

            CreateStartSlide(slideThickness);

            CreateSlide(slideThickness);

            CreateEndSlide(slideThickness);

            CreateSlideBorder(slideThickness);

            CreatePillar(6,60);

            CreateStairsBorder(15);

            CreateStairs();
        }

        /// <summary>
        /// Создать платформу.
        /// </summary>
        private void CreatePlatform()
        {
            CreateSketch(out var iSketch, out var iDefinitionSketch);

            const int platformBeginning = 0;

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(platformBeginning, platformBeginning,
                platformBeginning, _figureParams.PlatformThicknessT, 1);

            iDocument2D.ksLineSeg(platformBeginning, _figureParams.PlatformThicknessT, 
                _figureParams.PlatformLengthF, _figureParams.PlatformThicknessT, 1);

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF, _figureParams.PlatformThicknessT,
                _figureParams.PlatformLengthF, platformBeginning, 1);

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF, platformBeginning,
                platformBeginning, platformBeginning, 1);

            iDefinitionSketch.EndEdit();

            ExtrusionSketch(_iPart, iSketch, _figureParams.SlideWidthA, true);
        }

        /// <summary>
        /// Создать начало горки.
        /// </summary>
        /// <param name="thickness">Толщина</param>
        private void CreateStartSlide(int thickness)
        {

            CreateSketch(out ksEntity iSketch, out var iDefinitionSketch);

            const int startLengthBeginning = 0;

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF , startLengthBeginning, 
                _figureParams.PlatformLengthF , thickness, 1);

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF , thickness, 
                _figureParams.PlatformLengthF  +_figureParams.StartLengthE, thickness, 1);

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF  + _figureParams.StartLengthE, thickness,
                _figureParams.PlatformLengthF  + _figureParams.StartLengthE, startLengthBeginning, 1);

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF  + _figureParams.StartLengthE, 0,
                _figureParams.PlatformLengthF , startLengthBeginning, 1);

            iDefinitionSketch.EndEdit();

            ExtrusionSketch(_iPart, iSketch, _figureParams.SlideWidthA, true);
        }

        /// <summary>
        /// Создать горку.
        /// </summary>
        /// <param name="thickness">Толщина</param>
        private void CreateSlide(int thickness)
        {
            CreateSketch(out var iSketch, out var iDefinitionSketch);
            
            const int slideBeginning = 0;

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF +_figureParams.StartLengthE , slideBeginning,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE, thickness, 1);

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF + _figureParams.StartLengthE, thickness,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE +_figureParams.MainLengthL, 
                _figureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL,
                _figureParams.PlatformHeightG,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL,
                _figureParams.PlatformHeightG - thickness, 1);

            iDocument2D.ksLineSeg(
                 _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL, 
                 _figureParams.PlatformHeightG - thickness,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE , 0, 1);

            iDefinitionSketch.EndEdit();

            ExtrusionSketch(_iPart, iSketch, _figureParams.SlideWidthA, true);
        }

        /// <summary>
        /// Создать конец горки.
        /// </summary>
        /// <param name="thickness">Толщина</param>
        private void CreateEndSlide(int thickness)
        {
            CreateSketch(out var iSketch, out var iDefinitionSketch);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(
                _figureParams.PlatformLengthF + _figureParams.StartLengthE+ _figureParams.MainLengthL, 
                _figureParams.PlatformHeightG - thickness,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL,
                _figureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL,
                _figureParams.PlatformHeightG,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL + _figureParams.EndLengthD,
                _figureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL +_figureParams.EndLengthD,
                _figureParams.PlatformHeightG,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL +_figureParams.EndLengthD,
                _figureParams.PlatformHeightG - thickness, 1);

            iDocument2D.ksLineSeg(
                 _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL + _figureParams.EndLengthD,
                 _figureParams.PlatformHeightG - thickness,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE+_figureParams.MainLengthL,
                _figureParams.PlatformHeightG - thickness, 1);

            iDefinitionSketch.EndEdit();

            ExtrusionSketch(_iPart, iSketch, _figureParams.SlideWidthA, true);
        }

        /// <summary>
        /// Создать бортики горки.
        /// </summary>
        /// <param name="thickness">Толщина</param>
        private void CreateSlideBorder(int thickness)
        {
            CreateSketch(out var iSketch, out var iDefinitionSketch);

            const int borderDepth = 2;

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            CreateBorderSketch();

            iDefinitionSketch.EndEdit();

            ExtrusionSketch(_iPart, iSketch, borderDepth, false);

            CreateSketch(out iSketch, out iDefinitionSketch, _figureParams.SlideWidthA);


            iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            CreateBorderSketch();

            iDefinitionSketch.EndEdit();

            ExtrusionSketch(_iPart, iSketch, borderDepth, true);

            void CreateBorderSketch()
            {
                iDocument2D.ksLineSeg(
                _figureParams.PlatformLengthF,
                -_figureParams.BorderHeightC,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE,
                -_figureParams.BorderHeightC, 1);

                iDocument2D.ksLineSeg(
                    _figureParams.PlatformLengthF + _figureParams.StartLengthE,
                    -_figureParams.BorderHeightC,
                    _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL,
                    _figureParams.PlatformHeightG - thickness - _figureParams.BorderHeightC, 1);

                iDocument2D.ksLineSeg(
                    _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL,
                    _figureParams.PlatformHeightG - thickness - _figureParams.BorderHeightC,
                    _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL + _figureParams.EndLengthD,
                    _figureParams.PlatformHeightG - thickness - _figureParams.BorderHeightC, 1);

                iDocument2D.ksLineSeg(
                     _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL + _figureParams.EndLengthD,
                    _figureParams.PlatformHeightG - thickness - _figureParams.BorderHeightC,
                    _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL + _figureParams.EndLengthD,
                    _figureParams.PlatformHeightG, 1);

                iDocument2D.ksLineSeg(
                     _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL + _figureParams.EndLengthD,
                    _figureParams.PlatformHeightG,
                    _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL,
                    _figureParams.PlatformHeightG, 1);

                iDocument2D.ksLineSeg(
                     _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL,
                    _figureParams.PlatformHeightG,
                    _figureParams.PlatformLengthF + _figureParams.StartLengthE,
                     thickness, 1);

                iDocument2D.ksLineSeg(
                     _figureParams.PlatformLengthF + _figureParams.StartLengthE,
                     thickness,
                    _figureParams.PlatformLengthF,
                     thickness, 1);

                iDocument2D.ksLineSeg(
                     _figureParams.PlatformLengthF,
                     thickness,
                    _figureParams.PlatformLengthF,
                    -_figureParams.BorderHeightC, 1);
            }
        }

        /// <summary>
        /// Создать балки.
        /// </summary>
        /// <param name="thickness">Толщина</param>
        /// <param name="barriersHeight">Высота барьера</param>
        private void CreatePillar(int thickness,int barriersHeight)
        {
            CreateSketch(out var iSketch, out var iDefinitionSketch);

            const int pillarBeginning = 0;

            var barrierBarHeight = barriersHeight - 20;


            var iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            CreateRightPillarSketch();

            CreateLeftPillarSketch();

            CreateBarrierSketch();

            iDefinitionSketch.EndEdit();

            ExtrusionSketch(_iPart, iSketch, thickness, false);

            CreateSketch(out iSketch, out iDefinitionSketch, _figureParams.SlideWidthA);


            iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            CreateRightPillarSketch();

            CreateLeftPillarSketch();

            CreateBarrierSketch();

            iDefinitionSketch.EndEdit();

            ExtrusionSketch(_iPart, iSketch, thickness, true);

            void CreateRightPillarSketch()
            {
                iDocument2D.ksLineSeg(pillarBeginning, -barriersHeight,
                    thickness, -barriersHeight, 1);

                iDocument2D.ksLineSeg(thickness, -barriersHeight,
                    thickness, _figureParams.PlatformHeightG, 1);

                iDocument2D.ksLineSeg(thickness, _figureParams.PlatformHeightG,
                    pillarBeginning, _figureParams.PlatformHeightG, 1);

                iDocument2D.ksLineSeg(pillarBeginning, _figureParams.PlatformHeightG,
                    pillarBeginning, -barriersHeight, 1);
            }

            void CreateLeftPillarSketch()
            {
                iDocument2D.ksLineSeg(pillarBeginning + _figureParams.PlatformLengthF, -barriersHeight,
                    thickness + _figureParams.PlatformLengthF, -barriersHeight, 1);

                iDocument2D.ksLineSeg(thickness + _figureParams.PlatformLengthF, -barriersHeight,
                    thickness + _figureParams.PlatformLengthF, _figureParams.PlatformHeightG, 1);

                iDocument2D.ksLineSeg(thickness + _figureParams.PlatformLengthF, _figureParams.PlatformHeightG,
                    pillarBeginning + _figureParams.PlatformLengthF, _figureParams.PlatformHeightG, 1);

                iDocument2D.ksLineSeg(pillarBeginning + _figureParams.PlatformLengthF, _figureParams.PlatformHeightG,
                    pillarBeginning + _figureParams.PlatformLengthF, -barriersHeight, 1);
            }

            void CreateBarrierSketch()
            {
                iDocument2D.ksLineSeg(thickness, -barrierBarHeight,
                    _figureParams.PlatformLengthF, -barrierBarHeight, 1);

                iDocument2D.ksLineSeg(_figureParams.PlatformLengthF, -barrierBarHeight,
                    _figureParams.PlatformLengthF, -barrierBarHeight + thickness, 1);

                iDocument2D.ksLineSeg(_figureParams.PlatformLengthF, -barrierBarHeight + thickness,
                    thickness, -barrierBarHeight + thickness, 1);

                iDocument2D.ksLineSeg(thickness, -barrierBarHeight + thickness,
                    thickness, -barrierBarHeight, 1);
            }
        }

        /// <summary>
        /// Создает бортики для лестницы.
        /// </summary>
        /// <param name="borderHeight">Высота бортика</param>
        private void CreateStairsBorder(int borderHeight)
        {
            CreateSketch(out var iSketch, out var iDefinitionSketch);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            const int borderLength = 100;

            const int borderBeginning = 0;
            
            const int borderDepth = 2;

            const int borderBetweenPlatform = 5;

            CreateStairsBorderSketch();

            iDefinitionSketch.EndEdit();

            ExtrusionSketch(_iPart, iSketch, borderDepth, false);

            CreateSketch(out iSketch, out iDefinitionSketch, _figureParams.SlideWidthA);

            iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            CreateStairsBorderSketch();

            iDefinitionSketch.EndEdit();

            void CreateStairsBorderSketch()
            {
                iDocument2D.ksLineSeg(borderBeginning, borderBeginning + borderBetweenPlatform,
                    borderBeginning, -borderHeight + borderBetweenPlatform, 1);

                iDocument2D.ksLineSeg(borderBeginning, -borderHeight + borderBetweenPlatform,
                    -borderLength, _figureParams.PlatformHeightG - borderHeight + borderBetweenPlatform, 1);

                iDocument2D.ksLineSeg(-borderLength, _figureParams.PlatformHeightG - borderHeight + borderBetweenPlatform,
                    -borderLength, _figureParams.PlatformHeightG + borderBetweenPlatform, 1);

                iDocument2D.ksLineSeg(-borderLength, _figureParams.PlatformHeightG + borderBetweenPlatform,
                    borderBeginning, borderBeginning + borderBetweenPlatform, 1);
            }

            ExtrusionSketch(_iPart, iSketch, borderDepth, true);
        }

        /// <summary>
        /// Создать ступеньку.
        /// </summary>
        /// <param name="x"> Координата по х</param>
        /// <param name="y"> Координата по у</param>
        private void CreateStair(double x, double y)
        {
            CreateSketch(out var iSketch, out var iDefinitionSketch);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            const int stairLength = 15;

            const int stairHeight =2;

            iDocument2D.ksLineSeg(x, y, x, y + stairHeight, 1);

            iDocument2D.ksLineSeg(x, y + stairHeight, x - stairLength, y + stairHeight, 1);

            iDocument2D.ksLineSeg(x - stairLength, y + stairHeight, x - stairLength, y, 1);

            iDocument2D.ksLineSeg(x - stairLength, y, x, y, 1);

            iDefinitionSketch.EndEdit();

            ExtrusionSketch(_iPart, iSketch, _figureParams.SlideWidthA, true);
        }

        /// <summary>
        /// Создать лестницу.
        /// </summary>
        private void CreateStairs()
        {
            const double stairsLength = 100;
            double x1 = 0;
            double y1 = 0;
            if (_figureParams != null)
            {
                var formula = _figureParams.PlatformHeightG / 8f; 

                var x = - stairsLength / formula;
                var y = _figureParams.PlatformHeightG / formula;

                for( int i = 0; i < formula ; i++)
                {
                    CreateStair(x1,y1);
                    x1 = x1 + x;
                    y1 = y1 + y;
                }
            }
        }

        /// <summary>
        /// Создать эскиз.
        /// </summary>
        /// <param name="iSketch">Эскиз</param>
        /// <param name="iDefinitionSketch">Определение эскиза</param>
        /// <param name="offset">Смещение от начальной плоскости</param>
        private void CreateSketch(out ksEntity iSketch, out ksSketchDefinition iDefinitionSketch, double offset = 0)
        {
            #region Создать смещенную плоскость 
            ksEntity iPlane = (ksEntity)_iPart.NewEntity((short)Obj3dType.o3d_planeOffset);

            ksPlaneOffsetDefinition iPlaneDefinition = (ksPlaneOffsetDefinition)iPlane.GetDefinition();

            iPlaneDefinition.SetPlane(_iPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ));

            iPlaneDefinition.direction = true;

            iPlaneDefinition.offset = offset;

            iPlane.Create();
            #endregion 

            iSketch = (ksEntity)_iPart.NewEntity((short)Obj3dType.o3d_sketch);

            iDefinitionSketch = iSketch.GetDefinition();

            iDefinitionSketch.SetPlane(iPlane);

            iSketch.Create();
        }

        /// <summary>
        /// Выдавливание по эскизу.
        /// </summary>
        /// <param name="iPart">Интерфейс детали</param>
        /// <param name="iSketch">Эскиз</param>
        /// <param name="depth">Глубина выдавливания</param>
        /// <param name="direction">Направление выдавливания</param>
        private void ExtrusionSketch(ksPart iPart, ksEntity iSketch, double depth, bool direction)
        {
            ksEntity iExtrusion = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_bossExtrusion);

            ksBossExtrusionDefinition extrusionDef = (ksBossExtrusionDefinition)iExtrusion.GetDefinition();

            ksExtrusionParam extrusionParam = (ksExtrusionParam)extrusionDef.ExtrusionParam();

            extrusionDef.SetSketch(iSketch);

            if (direction == false)
            {
                extrusionParam.direction = (short)Direction_Type.dtReverse;
            }
            else
            {
                extrusionParam.direction = (short)Direction_Type.dtNormal;
            }

            extrusionParam.typeNormal = (short)End_Type.etBlind;

            if (direction == false)
            {
                extrusionParam.depthReverse = depth;
            }
            else
            {
                extrusionParam.depthNormal = depth;
            }

            iExtrusion.Create();
        }
    }
}
