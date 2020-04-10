using Kompas6API5;
using Kompas6Constants3D;

namespace KompasGorka.Model
{
    /// <summary>
    /// Класс для построения фигуры
    /// </summary>
    public class Builder
    {
        /// <summary>
        /// Параметры фигуры
        /// </summary>
        private FigureParams _figureParams;

        /// <summary>
        /// Интерфейс компонента
        /// </summary>
        private ksPart _iPart;

        /// <summary>
        /// Построить всю горку
        /// </summary>
        /// <param name="iPart"></param>
        /// <param name="figureParams"></param>
        public void Build(ksPart iPart, FigureParams figureParams)
        {
            _figureParams = figureParams;

            _iPart = iPart;

            CreatePlatform();

            CreateStartSlide();

            CreateSlide();

            CreateEndSlide();

            CreateBorder();

            CreatePillar();

            CreateStairsBorder();

            CreateStairs();
        }
        
        /// <summary>
        /// Создать платформу
        /// </summary>
        private void CreatePlatform()
        {
            ksEntity iSketch;

            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(0, 0, 0, 3, 1);
            iDocument2D.ksLineSeg(0, 3, _figureParams.PlatformLengthF, 3, 1);
            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF, 3, _figureParams.PlatformLengthF, 0, 1);
            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF, 0, 0, 0, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(_iPart, iSketch, _figureParams.SlideWidthA, true);
        }

        /// <summary>
        /// Создать начало горки
        /// </summary>
        private void CreateStartSlide()
        {
            ksEntity iSketch;

            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);


            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF , 0, 
                _figureParams.PlatformLengthF , 3, 1);

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF , 3, 
                _figureParams.PlatformLengthF  +_figureParams.StartLengthE, 3, 1);

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF  + _figureParams.StartLengthE, 3,
                _figureParams.PlatformLengthF  + _figureParams.StartLengthE, 0, 1);

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF  + _figureParams.StartLengthE, 0,
                _figureParams.PlatformLengthF , 0, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(_iPart, iSketch, _figureParams.SlideWidthA, true);
        }

        /// <summary>
        /// Создать горку
        /// </summary>
        private void CreateSlide()
        {
            ksEntity iSketch;

            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);


            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF +_figureParams.StartLengthE , 0,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE, 3, 1);

            iDocument2D.ksLineSeg(_figureParams.PlatformLengthF + _figureParams.StartLengthE, 3,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE +_figureParams.MainLengthL, 
                _figureParams.PlatformHeightG, 1);

            iDocument2D.ksLineSeg(
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL,
                _figureParams.PlatformHeightG,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL,
                _figureParams.PlatformHeightG - 3, 1);

            iDocument2D.ksLineSeg(
                 _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL, 
                 _figureParams.PlatformHeightG - 3,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE , 0, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(_iPart, iSketch, _figureParams.SlideWidthA, true);
        }

        /// <summary>
        /// Создать конец горки
        /// </summary>
        private void CreateEndSlide()
        {
            ksEntity iSketch;

            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);


            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(
                _figureParams.PlatformLengthF + _figureParams.StartLengthE+ _figureParams.MainLengthL, 
                _figureParams.PlatformHeightG - 3,
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
                _figureParams.PlatformHeightG - 3, 1);

            iDocument2D.ksLineSeg(
                 _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL + _figureParams.EndLengthD,
                 _figureParams.PlatformHeightG - 3,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE+_figureParams.MainLengthL,
                _figureParams.PlatformHeightG - 3, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(_iPart, iSketch, _figureParams.SlideWidthA, true);
        }
        
        /// <summary>
        /// Создать бортики
        /// </summary>
        private void CreateBorder()
        {
            ksEntity iSketch;
            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);


            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(
                _figureParams.PlatformLengthF, 
                -_figureParams.BorderHeightC, 
                _figureParams.PlatformLengthF + _figureParams.StartLengthE, 
                -_figureParams.BorderHeightC, 1);

            iDocument2D.ksLineSeg(
                _figureParams.PlatformLengthF + _figureParams.StartLengthE,
                -_figureParams.BorderHeightC,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE +_figureParams.MainLengthL, 
                _figureParams.PlatformHeightG -3 - _figureParams.BorderHeightC, 1);

            iDocument2D.ksLineSeg(
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL,
                _figureParams.PlatformHeightG - 3 - _figureParams.BorderHeightC,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL +_figureParams.EndLengthD,
                _figureParams.PlatformHeightG - 3 - _figureParams.BorderHeightC, 1);

            iDocument2D.ksLineSeg(
                 _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL + _figureParams.EndLengthD,
                _figureParams.PlatformHeightG - 3 - _figureParams.BorderHeightC,
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
                3, 1);

            iDocument2D.ksLineSeg(
                 _figureParams.PlatformLengthF + _figureParams.StartLengthE,
                3,
                _figureParams.PlatformLengthF,
                3, 1);

            iDocument2D.ksLineSeg(
                 _figureParams.PlatformLengthF,
                3,
                _figureParams.PlatformLengthF,
                -_figureParams.BorderHeightC, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(_iPart, iSketch, 2, false);

            CreateSketch(out iSketch, out iDefinitionSketch, _figureParams.SlideWidthA);


            iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(
                _figureParams.PlatformLengthF,
                -_figureParams.BorderHeightC,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE,
                -_figureParams.BorderHeightC, 1);

            iDocument2D.ksLineSeg(
                _figureParams.PlatformLengthF + _figureParams.StartLengthE,
                -_figureParams.BorderHeightC,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL,
                _figureParams.PlatformHeightG - 3 - _figureParams.BorderHeightC, 1);

            iDocument2D.ksLineSeg(
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL,
                _figureParams.PlatformHeightG - 3 - _figureParams.BorderHeightC,
                _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL + _figureParams.EndLengthD,
                _figureParams.PlatformHeightG - 3 - _figureParams.BorderHeightC, 1);

            iDocument2D.ksLineSeg(
                 _figureParams.PlatformLengthF + _figureParams.StartLengthE + _figureParams.MainLengthL + _figureParams.EndLengthD,
                _figureParams.PlatformHeightG - 3 - _figureParams.BorderHeightC,
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
                3, 1);

            iDocument2D.ksLineSeg(
                 _figureParams.PlatformLengthF + _figureParams.StartLengthE,
                3,
                _figureParams.PlatformLengthF,
                3, 1);

            iDocument2D.ksLineSeg(
                 _figureParams.PlatformLengthF,
                3,
                _figureParams.PlatformLengthF,
                -_figureParams.BorderHeightC, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(_iPart, iSketch, 2, true);
        }

        /// <summary>
        /// Создать балки
        /// </summary>
        private void CreatePillar()
        {
            ksEntity iSketch;

            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();
            
            iDocument2D.ksLineSeg(0, -50, 5, -50, 1);
            iDocument2D.ksLineSeg(5, -50, 5, _figureParams.PlatformHeightG, 1);
            iDocument2D.ksLineSeg(5, _figureParams.PlatformHeightG, 0, _figureParams.PlatformHeightG, 1);
            iDocument2D.ksLineSeg(0,_figureParams.PlatformHeightG, 0, -50, 1);
            iDocument2D.ksLineSeg(0 + _figureParams.PlatformLengthF, -50, 5 + _figureParams.PlatformLengthF, -50, 1);
            iDocument2D.ksLineSeg(5 + _figureParams.PlatformLengthF, -50, 5 + _figureParams.PlatformLengthF, _figureParams.PlatformHeightG, 1);
            iDocument2D.ksLineSeg(5 + _figureParams.PlatformLengthF, _figureParams.PlatformHeightG, 0 + _figureParams.PlatformLengthF, _figureParams.PlatformHeightG, 1);
            iDocument2D.ksLineSeg(0 + _figureParams.PlatformLengthF, _figureParams.PlatformHeightG, 0 + _figureParams.PlatformLengthF, -50, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(_iPart, iSketch, 5, false);

            CreateSketch(out iSketch, out iDefinitionSketch, _figureParams.SlideWidthA);

            iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(0, -50, 5, -50, 1);
            iDocument2D.ksLineSeg(5, -50, 5, _figureParams.PlatformHeightG, 1);
            iDocument2D.ksLineSeg(5, _figureParams.PlatformHeightG, 0, _figureParams.PlatformHeightG, 1);
            iDocument2D.ksLineSeg(0, _figureParams.PlatformHeightG, 0, -50, 1);
            iDocument2D.ksLineSeg(0 + _figureParams.PlatformLengthF, -50, 5 + _figureParams.PlatformLengthF, -50, 1);
            iDocument2D.ksLineSeg(5 + _figureParams.PlatformLengthF, -50, 5 + _figureParams.PlatformLengthF, _figureParams.PlatformHeightG, 1);
            iDocument2D.ksLineSeg(5 + _figureParams.PlatformLengthF, _figureParams.PlatformHeightG, 0 + _figureParams.PlatformLengthF, _figureParams.PlatformHeightG, 1);
            iDocument2D.ksLineSeg(0 + _figureParams.PlatformLengthF, _figureParams.PlatformHeightG, 0 + _figureParams.PlatformLengthF, -50, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(_iPart, iSketch, 5, true);
        }

        /// <summary>
        /// Создает бортики для лестницы
        /// </summary>
        private void CreateStairsBorder()
        {
            ksEntity iSketch;
            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(0, 0+3, 0, -15+3 , 1);
            iDocument2D.ksLineSeg(0, -15+3, -100, _figureParams.PlatformHeightG - 15+3, 1);
            iDocument2D.ksLineSeg(-100, _figureParams.PlatformHeightG -15+3, -100, _figureParams.PlatformHeightG+3, 1);
            iDocument2D.ksLineSeg(-100, _figureParams.PlatformHeightG +3, 0, 0+3, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(_iPart, iSketch, 2, false);

            CreateSketch(out iSketch, out iDefinitionSketch, _figureParams.SlideWidthA);

            iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(0, 0 + 3, 0, -15 + 3, 1);
            iDocument2D.ksLineSeg(0, -15 + 3, -100, _figureParams.PlatformHeightG - 15 + 3, 1);
            iDocument2D.ksLineSeg(-100, _figureParams.PlatformHeightG - 15 + 3, -100, _figureParams.PlatformHeightG + 3, 1);
            iDocument2D.ksLineSeg(-100, _figureParams.PlatformHeightG + 3, 0, 0 + 3, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(_iPart, iSketch, 2, true);
        }

        /// <summary>
        /// Создать ступеньку
        /// </summary>
        /// <param name="x"> Координата по х</param>
        /// <param name="y"> Координата по у</param>
        private void CreateStair(double x, double y)
        {
            ksEntity iSketch;
            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksLineSeg(x, y, x, y +2, 1);
            iDocument2D.ksLineSeg(x, y +2, x - 15, y +2, 1);
            iDocument2D.ksLineSeg(x - 15, y +2, x - 15, y, 1);
            iDocument2D.ksLineSeg(x - 15, y, x, y, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(_iPart, iSketch, _figureParams.SlideWidthA, true);
        }

        /// <summary>
        /// Создать лестницу
        /// </summary>
        private void CreateStairs()
        {
            double x1 = 0;
            double y1 = 0;
            if (_figureParams != null)
            {
                double formula = _figureParams.PlatformHeightG / 8f; 

                double x = -100 / formula;
                double y = _figureParams.PlatformHeightG / formula;

                for( int i = 0; i < formula ; i++)
                {
                    CreateStair(x1,y1);
                    x1 = x1 + x;
                    y1 = y1 + y;
                }
            }
        }

        /// <summary>
        /// Создать эскиз
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
        /// Выдавливание по эскизу
        /// </summary>
        /// <param name="iPart">Интерфейс детали</param>
        /// <param name="iSketch">Эскиз</param>
        /// <param name="depth">Глубина выдавливания</param>
        /// <param name="direction">Направление выдавливания</param>
        private void ExctrusionSketch(ksPart iPart, ksEntity iSketch, double depth, bool direction)
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
