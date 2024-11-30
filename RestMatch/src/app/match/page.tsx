"use client";

import Image from "next/image";
import heartIcon from "../../../public/assets/images/match/icon-heart.svg";
import editIcon from "../../../public/assets/images/match/icon-edit.svg";
import arrowIcon from "../../../public/assets/images/match/icon-back.svg";
import imageArrowIcon from "../../../public/assets/images/match/icon-forward.svg";
import Stat from "@/components/info/Stat";
import {useCallback, useEffect, useState} from "react";
import {iconUrl} from "@/utils/constants";
import restaurantService from "@/services/restaurant.service";
import {Restaurant} from "@/models/Restaurant";
import {useSwipeable} from "react-swipeable";
import {favouritesService} from "@/services/favourites.service";

export default function Match() {
  return (
    <div className="flex justify-center pt-5 pb-5 bg-[#9F784E]">
      <Card/>
    </div>
  );
}

function Card() {
  const countOfPhoto = 3;

  const [recommendations, setRecommendations] = useState<Restaurant[]>([]);
  const [currRecommendation, setCurrRecommendation] = useState(0);
  const [currImageIdx, setCurrImageIdx] = useState(0);
  const [swipeDirection, setSwipeDirection] = useState<"left" | "right" | null>(null);

  const fetchRecommendations = useCallback(async () => {
    const response = await restaurantService.getRecommendations(1, 10);
    setRecommendations(response.data.entities);
  }, []);

  useEffect(() => {
    fetchRecommendations();
  }, [fetchRecommendations]);

  const handleArrowClick = (direction: "left" | "right") => {
    if (direction === 'left') {
      onSwipe({dir: "Left"});
    } else {
      onSwipe({dir: "Right"});
    }
  }

  const getRecommendation = () => {
    if (recommendations.length === 0) {
      return null;
    }
    return recommendations[currRecommendation]
  }

  const onSwipe = async (eventData: any) => {
    if (eventData.dir === "Left") {
      setSwipeDirection("left");
    } else if (eventData.dir === "Right") {
      setSwipeDirection("right");
    }
    setTimeout(() => {
      setSwipeDirection(null);
      handleAddRate(getRecommendation()?.id.toString());
      setCurrRecommendation((prev) => {
        return prev + 1;
      });
    }, 300); // Duration of the animation
  }

  const handlers = useSwipeable({
    onSwiped: (eventData) => onSwipe(eventData),
    trackMouse: true,
    delta: 5,
    preventScrollOnSwipe: true,
  });

  const handleAddRate = async (id: string | undefined) => {
    if (!id) {
      return;
    }
    await favouritesService.addFavourites(id);
  }

  return (
    <div
      className={`flex flex-col w-4/5 justify-center text-white border-0 rounded-b-2xl bg-[#947654] rounded-t-3xl drop-shadow-2xl ${swipeDirection ? `swipe-${swipeDirection}` : ''}`}>
      <div
        className={`border-[5px] border-black rounded-3xl relative inline-block drop-shadow-2xl`}
        {...handlers}
      >
        <Image
          src="/assets/images/homepage/background.png"
          alt="Restourant image"
          width={0}
          height={0}
          sizes="100vw"
          className="rounded-2xl overflow-hidden object-cover height-[600px] w-full swiper"
        />
        <div className="swiper absolute bottom-0 left-0 bg-opacity-50 bg-black rounded-2xl z-[100] w-[420px] h-[240px]">
          <div
            className="flex flex-col justify-center items-center w-full h-full text-[32px] leading-[42px] font-medium">
            <span>Bibliotekа resto•Bar</span>
            <span>Lviv • 150 ₴ • Italic</span>
          </div>
        </div>
        <div
          className="swiper absolute rounded-full bg-[#5D462D] w-[130px] h-[130px] z-[101]"
          style={{
            bottom: -60,
            left: 35,
          }}
        >
          <div
            className="swiper w-full h-full flex justify-center items-center cursor-pointer"
            onClick={() => handleArrowClick("left")}>
            <Image
              src={arrowIcon}
              alt="forward icon"
              style={{transform: "rotate(3.142rad)"}}
            />
          </div>
        </div>
        <div
          className="absolute rounded-full bg-[#CF914E] w-[100px] h-[100px] z-[101]"
          style={{
            bottom: -50,
            left: 200,
          }}
        >
          <div className="w-full h-full flex justify-center items-center">
            <Image src={editIcon} alt="add review icon"/>
          </div>
        </div>
        <div
          className="absolute rounded-full bg-[#5D462D] w-[130px] h-[130px] z-[101]"
          style={{
            bottom: -60,
            right: 35,
          }}
        >
          <div
            className="w-full h-full flex justify-center items-center cursor-pointer"
            onClick={() => handleArrowClick("right")}>
            <Image
              src={arrowIcon}
              alt="forward icon"
            />
          </div>
        </div>
        <div
          className="absolute rounded-full bg-[#A10005] w-[100px] h-[100px] z-[101]"
          style={{
            bottom: -50,
            right: 200,
          }}
        >
          <div className="w-full h-full flex justify-center items-center">
            <Image src={heartIcon} alt="heart icon"/>
          </div>
        </div>
        <div
          className="absolute rounded-full bg-[rgba(0,0,0,0.7)] w-[100px] h-[100px] z-[101]"
          style={{
            top: "40%",
            right: 10,
            display: currImageIdx === countOfPhoto - 1 ? "none" : "block",
          }}
          onClick={() => {
            const newIndex = currImageIdx + 1;

            if (newIndex < countOfPhoto) {
              setCurrImageIdx(newIndex);
            }
          }}
        >
          <div className="flex justify-center items-center w-full h-full">
            <Image src={imageArrowIcon} alt="arrow icon"/>
          </div>
        </div>
        <div
          className="absolute rounded-full bg-[rgba(0,0,0,0.7)] w-[100px] h-[100px] z-[101]"
          style={{
            top: "40%",
            left: 10,
            display: currImageIdx === 0 ? "none" : "block",
          }}
          onClick={() => {
            const newIndex = currImageIdx - 1;

            if (newIndex >= 0) {
              setCurrImageIdx(newIndex);
            }
          }}
        >
          <div
            className="flex justify-center items-center w-full h-full"
            style={{
              transform: "rotate(3.142rad)",
            }}
          >
            <Image src={imageArrowIcon} alt="arrow icon"/>
          </div>
        </div>
        <div
          className="absolute z-[101]"
          style={{
            left: "50%",
            bottom: 20,
          }}
        >
          <div className="flex flex-row gap-3">
            {[0, 0, 0].map((_, index) => {
              return (
                <div
                  key={index}
                  className="rounded-full w-[14px] h-[14px]"
                  style={{
                    backgroundColor:
                      index === currImageIdx ? "#FFF" : "#000",
                    opacity: index === currImageIdx ? "100%" : "50%",
                  }}
                ></div>
              );
            })}
          </div>
        </div>
      </div>

      <div id="card_content" className="pt-20 pl-8 pr-8">
        <h1 className="text-5xl ml-8">{getRecommendation()?.name}</h1>
        <div className="flex flex-row mt-6 text-[36px] leading-[48px] font-semibold">
          <div className="inline-block w-1/2">
            <Stat icon="point" content={getRecommendation()?.address} styles="mb-5"/>
            <Stat icon="clock" content="10:00 — 22:00" styles="mb-5"/>
            <Stat icon="coin" content={`${getRecommendation()?.lowerPrice}-${getRecommendation()?.upperPrice} ₴`}/>
          </div>
          <div className="inline-block w-1/2">
            <Stat icon="cutlery" content="Italic food" styles="mb-5"/>
            <Stat icon="telephone" content={getRecommendation()?.phoneNumber} styles="mb-5"/>
            <Stat icon="menu" content="Menu"/>
          </div>
        </div>
        <div className="mt-6 text-[25px] font-semibold leading-[34px]">
          {getRecommendation()?.aboutText}
        </div>
      </div>
      <div className="pt-6 pl-8 pr-8 pb-10">
        <h1 className="text-5xl ml-8 mb-4">Client&#39;s Review</h1>
        <hr className="pb-7"/>
        <div className="flex   gap-8">
          <div className="bg-[#5D462D] rounded-full py-6 px-5 shrink-0 h-fit">
            <img src={`${iconUrl}/cake.svg`} alt="cake"/>
          </div>
          <div className="flex flex-col gap-3">
            <span className="text-4xl font-medium">Sweet Cake</span>
            <img className="w-fit" src={`${iconUrl}/hearts.svg`} alt="rating"/>
            <span className="text-2xl">
              Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi
              eget faucibus tortor. Vivamus blandit eros in enim mollis, vel
              lobortis neque eleifend. Sed a consectetur tellus, ut sodales
              nibh. Lorem ipsum dolor sit amet, consectetur adipiscing elit.
              Nullam ut nulla urna. Aliquam dolor nisl, convallis sit amet diam
              ut, tempor euismod massa. Etiam commodo placerat libero, ut
              placerat elit sagittis vel.
            </span>
          </div>
        </div>
      </div>
      <style jsx>{`
        .swiper {
          user-select: none;
          -moz-user-select: none;
          -khtml-user-select: none;
          -webkit-user-select: none;
          -o-user-select: none;
        }

        .swipe-left {
          transition: transform 0.3s ease-in-out;
          transform: translateX(-100%);
        }

        .swipe-right {
          transition: transform 0.3s ease-in-out;
          transform: translateX(100%);
        }
      `}</style>
    </div>
  );
}
