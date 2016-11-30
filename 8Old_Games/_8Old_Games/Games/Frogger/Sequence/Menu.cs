﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace _4Old_Games.Games.Frogger.Sequence {
    public class Menu : Sequence {
        //PLAY<->MENU 시퀀스 전환 시 입력 속도 제어용 변수
        private double mTimeAfterPlay=WAIT_TIME;
        private const double WAIT_TIME = 0.15;

        //유저가 선택한 속도(방향키), 엔터로 이동 가능
        private int chStage;
        private bool isFirst = true;

        public Menu() : base() {; }
        public override void initialize() {

        }

        public override State update(GameTime gameTime, KeyboardState ks) { return State.MENU; }

        public State update(GameTime gameTime, KeyboardState ks, int stage,out int outStage) {
            if (isFirst) {
                chStage = stage;
                isFirst = false;
            }
            //스페이스를 누르면 다시 PLAY 시퀀스로 이동
            //Enter를 누르면 방향키로 고른 스테이지 정보와 함께 LOAD 시퀀스로 이동
            mTimeSinceLastInput += gameTime.ElapsedGameTime.TotalSeconds;
            mTimeAfterPlay -= gameTime.ElapsedGameTime.TotalSeconds;
            if (mTimeSinceLastInput >= MIN_TIME) {
                if (mTimeAfterPlay <= 0) {
                    if (ks.IsKeyDown(Keys.Space)) {
                        mTimeAfterPlay = WAIT_TIME;
                        outStage = stage;
                        return State.PLAY;
                    } 
                    else if (ks.IsKeyDown(Keys.Enter)) {
                        outStage = chStage;
                        return State.LOAD;
                    }
                    else if (ks.IsKeyDown(Keys.Escape)) {
                        outStage = chStage;
                        return State.EXIT;
                    }
                }
                if (ks.IsKeyDown(Keys.Left)) {
                    if (chStage > 1) chStage--;
                } else if (ks.IsKeyDown(Keys.Right)) {
                    if (chStage < 24) chStage++;

                }
                mTimeSinceLastInput = 0.0f;
            }

            outStage = stage;
            return State.MENU;
        }

        public override void draw(SpriteBatch spriteBatch, Texture2D sprite, Vector2 origin) {; }


        public void draw(SpriteBatch spriteBatch, SpriteFont sf,Texture2D sprite,Vector2 origin) {
            spriteBatch.Draw(sprite, new Rectangle(0, 0, 800, 480), Color.White);
            spriteBatch.DrawString(sf, "" + chStage, new Vector2(315, 339), Color.Red);

        }

    }
}
