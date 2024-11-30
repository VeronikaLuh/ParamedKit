"use client";

import React, { useCallback, useEffect, useState } from "react";
import { iconUrl, imageUrl } from "@/utils/constants";
import Stat from "@/components/info/Stat";
import restaurantService from "@/services/restaurant.service";
import { Restaurant } from "@/models/Restaurant";
import { useParams } from "next/navigation";
import { rateService } from "@/services/rate.service";

const Info = () => {
  const [data, setData] = useState<Restaurant>();
  const [reviews, setReviews] = useState([]);

  const params = useParams();
  const { id } = params as { id: string };

  const fetchRestaurant = useCallback(async (id: string) => {
    const response = await restaurantService.getRestaurant(id);
    setData(response.data);
  }, []);

  const fetchReviews = useCallback(async (restaurantId: string) => {
    const response = await rateService.getRates(restaurantId);
    setReviews(response.data);
  }, []);

  useEffect(() => {
    if (!id) return;
    fetchRestaurant(id);
    fetchReviews(id);
  }, [fetchRestaurant, id]);

  const [rating, setRating] = useState<number>(0);
  const [hoveredRating, setHoveredRating] = useState<number>(0);

  const handleStarClick = (index: number): void => {
    setRating(index + 1);
  };

  const handleStarMouseOver = (index: number): void => {
    setHoveredRating(index + 1);
  };

  const handleStarMouseOut = (): void => {
    setHoveredRating(rating);
  };

  const highlightStars = (rating: number): string[] => {
    return [...Array(5)].map((_, index) =>
      index < rating ? "opacity-100" : "opacity-30"
    );
  };

  const getHeartImage = (index: number): string => {
    if (index < rating) {
      return `${imageUrl}/info/heart-filled.svg`;
    }
    return `${imageUrl}/info/heart.svg`;
  };

  return (
    <div className="px-2 md:mt-10 px-10">
      <div>
        <div className="flex">
          <h1>Biblioteka resto•bar</h1>
          <div className="bg-[#8A613599] size-8 rounded-full mt-6 p-1 ml-3 md:size-fit md:mt-4 md:ml-6 p-4">
            <img src={`${iconUrl}/bookmark.svg`} alt="bookmark" />
          </div>
        </div>
        <div className="flex mb-3 md:hidden">
          <div className="font-bold tetx-sm pb-1">5/5</div>
          <img
            className="w-36 pl-2"
            src={`${iconUrl}/hearts.svg`}
            alt="rating"
          />
        </div>
        <div className=" md:mt-10 flex gap-11">
          <img
            className=""
            src={`${imageUrl}/info/restaurant.png`}
            alt="restaurant"
          />
          <div className="hidden md:flex flex-col">
            <Stat icon="point" content={data?.address} styles="mb-10" />
            <Stat icon="clock" content="10:00 — 22:00" styles="mb-10" />
            <Stat
              icon="coin"
              content={`${data?.lowerPrice}-${data?.upperPrice} ₴`}
              styles="mb-10"
            />
            <Stat icon="cutlery" content="Italic food" styles="mb-10" />
            <Stat icon="telephone" content={data?.phoneNumber} styles="mb-10" />
            <Stat icon="menu" content="Menu" styles="mb-10" />
            <Stat
              icon="5"
              content={<img src={`${iconUrl}/hearts.svg`} alt="rating" />}
            />
          </div>
        </div>
        <div className="columns-2 md:hidden">
          <Stat icon="point" content={data?.address} />
          <Stat icon="clock" content="10:00 — 22:00" />
          <Stat
            icon="coin"
            content={`${data?.lowerPrice}-${data?.upperPrice} ₴`}
          />
          <Stat icon="cutlery" content="Italic food" />
          <Stat icon="telephone" content={data?.phoneNumber} />
          <Stat icon="menu" content="Menu" />
        </div>
        <div className="mt-0 md:mt-11">
          <h1>About</h1>
          <hr className="mb-6" />
          <span className="text-4xl font-medium">{data?.aboutText}</span>
        </div>
        <div className="mt-11">
          <h1>Client`s review</h1>
          <hr className="mb-7" />
          <div className="flex gap-4 md:gap-8">
            <div className="bg-[#5D462D] size-12 rounded-full py-1 px-1 shrink-0 md:py-6 md:size-fit md:px-5 h-fit">
              <img src={`${iconUrl}/cake.svg`} alt="cake" />
            </div>
            <div className="flex flex-col gap-3">
              <span className="text-lg font-medium md:text-4xl">
                Sweet Cake
              </span>
              <img
                className="w-36 md:w-fit"
                src={`${iconUrl}/hearts.svg`}
                alt="rating"
              />
              <span className="text-md md:text-2xl">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi
                eget faucibus tortor. Vivamus blandit eros in enim mollis, vel
                lobortis neque eleifend. Sed a consectetur tellus, ut sodales
                nibh. Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                Nullam ut nulla urna. Aliquam dolor nisl, convallis sit amet
                diam ut, tempor euismod massa. Etiam commodo placerat libero, ut
                placerat elit sagittis vel.
              </span>
            </div>
          </div>
        </div>
      </div>
      <div className="flex justify-end mt-3 pr-3 md:mt-5 pr-16 mb-14">
        <button className="bg-[#F0BB81] px-3 py-1 rounded-[20px] text-[16px] font-bold text-[#5D462D] md:text-[32px] md:px-8 py-1">
          Add new review
        </button>
      </div>
      <div className="bg-brown-200 p-6 rounded-lg w-full">
        <div className="flex items-center mb-4">
          <div className="flex cursor-pointer">
            {[...Array(5)].map((_, index) => (
              <div
                key={index}
                onClick={() => handleStarClick(index)}
                onMouseOver={() => handleStarMouseOver(index)}
                onMouseOut={handleStarMouseOut}
                className={`w-[2.5rem] h-[2.5rem] ${
                  highlightStars(hoveredRating)[index]
                }`}
              >
                <img
                  src={getHeartImage(index)}
                  alt="Heart"
                  className="w-full h-full object-contain"
                />
              </div>
            ))}
          </div>
          <span className="text-[2.5rem] ml-2 text-sm text-white">
            {rating}/5
          </span>
        </div>
        <textarea
          className="w-full h-32 p-3 text-gray-700 bg-white border border-gray-300 rounded-md resize-none "
          placeholder="Type your thoughts..."
        />
        <div className="flex justify-end mt-4">
          <button className="px-6 py-2 text-[2rem] bg-[#CF914E] text-white font-bold rounded-[1.25rem]">
            Share
          </button>
        </div>
      </div>
    </div>
  );
};

export default Info;
