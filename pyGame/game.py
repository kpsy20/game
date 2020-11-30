#필요한 것들 import
import pygame
from pygame.locals import *
import math
import random
#파이게임이 뜨는 창 크기 설정(1080*480)
pygame.init()
width, height = 1080, 480
screen=pygame.display.set_mode((width, height))

#이미지들 불러옴
player = pygame.image.load(r"./character.png")
grass = pygame.image.load(r"./grass.png")
house1 = pygame.image.load(r"./house1.png")
house2 = pygame.image.load(r"./house2.png")
house3 = pygame.image.load(r"./house3.png")
house4 = pygame.image.load(r"./house4.png")
arrow = pygame.image.load(r"./arrow.png")
badguyimg1 = pygame.image.load(r"./virus.png")
badguyimg=badguyimg1
gameover = pygame.image.load(r"./game-over.png")
youwin = pygame.image.load(r"./trophy.png")
play = pygame.image.load(r"./play.png")
#background color
White = (255, 255, 255)
start = True
#초기 플레이 전 화면 설정
while start:
        #배경을 흰색으로 설정하고
        screen.fill(White)
        #(412, 25) 위치에 play 이미지 띄움
        screen.blit(play, (412, 25))
        pygame.display.flip()
        #사용자가 마우스를 누르거나 키보드를 눌렀을 때
        for event in pygame.event.get():
            #position = 사용자 마우스 포인터 위치
            position = pygame.mouse.get_pos()
            #마우스를 클릭했고, 그 때 마우스 포인터 위치가 버튼 위일 때 게임 시작
            if event.type==pygame.MOUSEBUTTONDOWN and position[0] <=668 and position[0] >= 412 and position[1] >= 25 and position[1] <= 281:
                start = False
                start_tick = pygame.time.get_ticks()
            #게임 끄는 부분
            if event.type == pygame.QUIT:
                pygame.quit()
                exit(0)
#게임 시작과 끝에 필요한 list
running_exitcode = [1, 0]
# 4 - keep looping through
def run():
    #게임 초기 설정들
    healthvalue=100
    keys = [False, False, False, False]
    #처음 플레이어 위치
    playerpos=[100, 240]
    #마스크 들이 담기는 list
    arrows=[]
    #바이러스가 나오는 시간, 위치에 필요한 변수들
    badtimer=100
    badtimer1=0
    badguys=[[1080,100]]
    while running_exitcode[0]:
        badtimer-=1
        #배경 흰색 설정
        screen.fill(White)
        #배경에 잔디와 집 넣는 부분
        for x in range(1, int(width/grass.get_width()+1)):
            for y in range(int(height/grass.get_height()+1)):
                screen.blit(grass,(x*100,y*100))
        screen.blit(house1,(0,30))
        screen.blit(house2,(0,135))
        screen.blit(house3,(0,240))
        screen.blit(house4,(0,345))
        #position = 마우스 포인터 위치
        position = pygame.mouse.get_pos()
        #마우스와 플레이어 위치에 따라 플레이어가 바라보는 방향 바꾸는 코드
        angle = math.atan2(position[1]-(playerpos[1]+32),position[0]-(playerpos[0]+26))
        playerrot = pygame.transform.rotate(player, 360-angle*57.29)
        playerpos1 = (playerpos[0]-playerrot.get_rect().width/2, playerpos[1]-playerrot.get_rect().height/2)
        screen.blit(playerrot, playerpos1)
        #클릭했을 때 생기는 마스크들 관리하는 for 문
        for bullet in arrows:
            index=0
            #x축 속도와 y축 속도를 sin, cos로 계산 *12 부분을 바꾸면 마스크 속도 변함
            velx=math.cos(bullet[0])*12
            vely=math.sin(bullet[0])*12
            #bullet[1]이 x축 속도, bullet[2]가 y축 속도
            bullet[1]+=velx
            bullet[2]+=vely
            #마스크가 화면 밖으로 나가면 삭제
            if bullet[1]<-64 or bullet[1]>1080 or bullet[2]<-64 or bullet[2]>480:
                arrows.pop(index)
            index+=1
            #날리는 방향에 따른 마스크 모양 변화
            for projectile in arrows:
                arrow1 = pygame.transform.rotate(arrow, 360-projectile[0]*57.29)
                screen.blit(arrow1, (projectile[1], projectile[2]))
        #바이러스 생성부분 badtimer가 0일때 마다 생성
        if badtimer==0:
            #badguys라는 list에 각각의 바이러스 넣음, 생성되는 위치는 [1080, 50~430] 으로 y축 좌표만 랜덤
            badguys.append([1080, random.randint(50,430)])
            #badimter가 초기에는 100이었다가 점점 줄어들어서 게임 후반으로 갈 수록 바이러스가 나오는 주기가 줄어드는 부분
            badtimer=100-(badtimer1*2)
            if badtimer1>=10:
                badtimer1=10
            else:
                badtimer1+=5
        index=0
        #화면 밖으로 나가는 바이러스 삭제
        for badguy in badguys:
            if badguy[0]<-64:
                badguys.pop(index)
            #바이러스의 속도
            badguy[0]-=3
            # 6.3.1 - Attack castle
            index1=0
            #마스크와 바이러스가 만났을 때 마스크 삭제, 바이러스 삭제 하는 부분
            for bullet in arrows:
                bullrect=pygame.Rect(arrow.get_rect())
                bullrect.left=bullet[1]
                bullrect.top=bullet[2]
                if badrect.colliderect(bullrect):
                    badguys.pop(index-1)
                    arrows.pop(index1)
                index1+=1
            #바이러스가 집에 도착했을 때 삭제하고 health 감소하는 부분
            badrect=pygame.Rect(badguyimg.get_rect())
            badrect.top=badguy[1]
            badrect.left=badguy[0]
            if badrect.left<64:
                healthvalue -= 11
                badguys.pop(index)
        #바이러스 위치 갱신 코드 
            index+=1
        for badguy in badguys:
            screen.blit(badguyimg, badguy)


        #현재 남은 시간 출력하는 부분
        font = pygame.font.Font(None, 24)
        survivedtext = font.render("Remaining Time"+" : "+str(int((90000-pygame.time.get_ticks()+start_tick)/1000)).zfill(2) + " Seconds", True, (0,0,0))
        textRect = survivedtext.get_rect()
        #글씨가 뜨는 위치
        textRect.midtop=[540,15]
        screen.blit(survivedtext, textRect)
        #현재 남은 피 출력하는 부분
        healthtext = font.render(str(healthvalue)+" Health",True, (0,0,0))
        textRect2 = healthtext.get_rect()
        #글씨가 뜨는 위치
        textRect2.midtop=[50,15]
        screen.blit(healthtext, textRect2)
        pygame.display.flip()
        for event in pygame.event.get():
            #게임 하던 도중 게임 끌 때
            if event.type==pygame.QUIT:
                pygame.quit()
                exit(0)
            #wasd버튼으로 캐릭터 이동시킬 때 필요한 코드 키를 누를 때 true로 변하고 뗄 때 false로 변해 true인 동안 이동하게함
            if event.type == pygame.KEYDOWN:
                if event.key==K_w:
                    keys[0]=True
                elif event.key==K_a:
                    keys[1]=True
                elif event.key==K_s:
                    keys[2]=True
                elif event.key==K_d:
                    keys[3]=True
            if event.type == pygame.KEYUP:
                if event.key==pygame.K_w:
                    keys[0]=False
                elif event.key==pygame.K_a:
                    keys[1]=False
                elif event.key==pygame.K_s:
                    keys[2]=False
                elif event.key==pygame.K_d:
                    keys[3]=False
            #마우스 좌클릭 했을 때 마스크 생성하는 코드
            if event.type==pygame.MOUSEBUTTONDOWN:
                position=pygame.mouse.get_pos()
                arrows.append([math.atan2(position[1]-(playerpos1[1]+32),position[0]-(playerpos1[0]+26)),playerpos1[0]+32,playerpos1[1]+32])
        #캐릭터 이동, =1.5 숫자 바꾸면 이동속도 변함
        if keys[0]:
            playerpos[1]-=1.5
        elif keys[2]:
            playerpos[1]+=1.5
        if keys[1]:
            playerpos[0]-=1.5
        elif keys[3]:
            playerpos[0]+=1.5

        #게임이 끝날때 조건1. 90초 동안 살아남았을때, 조건2. 피가0 이하로 됐을 때
        if pygame.time.get_ticks()>=90000 + start_tick:
            running_exitcode[0]=0
            running_exitcode[1]=1
        if healthvalue<=0:
            running_exitcode[0]=0
            running_exitcode[1]=0
            
#이제 여기서 게임이 시작되는것. run함수를 돌려줌
while 1:
    #게임시작
    if running_exitcode[0] == 1:
        run()
    #피0 이하됐을때 gameover띄우는곳
    if running_exitcode[1]==0:
        pygame.font.init()
        font = pygame.font.Font(None, 48)
        screen.blit(gameover, (284, -10))
    #90초 버텼을 때 트로피 띄우는곳
    else:
        pygame.font.init()
        font = pygame.font.Font(None, 48)
        screen.blit(youwin, (284, -10))
    #다시 시작하려면 R키 누르세요
    restart_text = font.render("If you want to restart, press 'R'", True, (255,0,0))
    textRect = restart_text.get_rect()
    textRect.midtop=[540,100]
    screen.blit(restart_text, textRect)
    #사용자 이벤트 받아서 게임 끄면 꺼지고, R키 누르면 재 시작
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            exit(0)
        if event.type == pygame.KEYDOWN:
            if event.key == K_r:
                running_exitcode[0]=1
                restart_tick = pygame.time.get_ticks()
                start_tick = restart_tick
    pygame.display.flip()

