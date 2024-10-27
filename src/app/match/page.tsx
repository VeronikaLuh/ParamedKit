"use client";

import Image from "next/image";
import averagePriceIcon from "../../../public/assets/images/match/icon-average-price.svg";
import clockIcon from "../../../public/assets/images/match/icon-clock.svg";
import pointIcon from "../../../public/assets/images/match/icon-point.svg";
import phoneIcon from "../../../public/assets/images/match/icon-phone.svg";
import restaurantIcon from "../../../public/assets/images/match/icon-restaurant.svg";
import moreDetailsIcon from "../../../public/assets/images/match/icon-more-details.svg";
import heartIcon from "../../../public/assets/images/match/icon-heart.svg";
import editIcon from "../../../public/assets/images/match/icon-edit.svg";
import arrowIcon from "../../../public/assets/images/match/icon-back.svg";
import imageArrowIcon from "../../../public/assets/images/match/icon-forward.svg";
import { useState } from "react";

export default function Match() {
  return (
    <div className="flex justify-center mt-5 mb-5">
      <Card />
    </div>
  );
}

function Card() {
  const countOfPhoto = 3;
  const [currentPhotoIndex, setCurrentPhotoIndex] = useState(0);

  return (
    <div
      className="flex flex-col w-4/5 justify-center text-white border border-0 rounded-b-2xl rounded-t-3xl"
      style={{ backgroundColor: "#9F784E" }}
    >
      <div
        className="border rounded-3xl relative inline-block"
        style={{ border: "5px #000000 solid" }}
      >
        <Image
          src="/assets/images/homepage/background.png"
          alt="Restourant image"
          width={0}
          height={0}
          sizes="100vw"
          style={{
            width: "100%",
            height: "600px",
            objectFit: "cover",
            overflow: "hidden",
          }}
          className="rounded-2xl"
        />
        <div
          className="absolute bottom-0 left-0 bg-opacity-50 bg-black rounded-2xl"
          style={{ zIndex: "100", width: "420px", height: "240px" }}
        >
          <div
            className="flex flex-col justify-center items-center"
            style={{
              width: "100%",
              height: "100%",
              fontSize: "32px",
              fontWeight: "500",
              lineHeight: "42px",
            }}
          >
            <span>Bibliotekа resto•Bar</span>
            <span>Lviv • 150 ₴ • Italic</span>
          </div>
        </div>
        <div
          className="absolute rounded-full"
          style={{
            backgroundColor: "#5D462D",
            width: "130px",
            height: "130px",
            bottom: -60,
            left: 35,
            zIndex: 101,
          }}
        >
          <div
            className="flex justify-center items-center"
            style={{ width: "100%", height: "100%" }}
          >
            <Image
              src={arrowIcon}
              alt="forward icon"
              style={{ transform: "rotate(3.142rad)" }}
            />
          </div>
        </div>
        <div
          className="absolute rounded-full"
          style={{
            backgroundColor: "#CF914E",
            width: "100px",
            height: "100px",
            bottom: -50,
            left: 200,
            zIndex: 102,
          }}
        >
          <div
            className="flex justify-center items-center"
            style={{ width: "100%", height: "100%" }}
          >
            <Image src={editIcon} alt="add review icon" />
          </div>
        </div>
        <div
          className="absolute rounded-full"
          style={{
            backgroundColor: "#5D462D",
            width: "130px",
            height: "130px",
            bottom: -60,
            right: 35,
            zIndex: 101,
          }}
        >
          <div
            className="flex justify-center items-center"
            style={{ width: "100%", height: "100%" }}
          >
            <Image src={arrowIcon} alt="forward icon" />
          </div>
        </div>
        <div
          className="absolute rounded-full"
          style={{
            backgroundColor: "#A10005",
            width: "100px",
            height: "100px",
            bottom: -50,
            right: 200,
            zIndex: 102,
          }}
        >
          <div
            className="flex justify-center items-center"
            style={{ width: "100%", height: "100%" }}
          >
            <Image src={heartIcon} alt="heart icon" />
          </div>
        </div>
        <div
          className="absolute rounded-full"
          style={{
            backgroundColor: "rgba(0,0,0,0.7)",
            width: "100px",
            height: "100px",
            top: "40%",
            right: 10,
            zIndex: 102,
          }}
          onClick={() => {
            const newIndex = currentPhotoIndex + 1;

            if (newIndex < countOfPhoto) {
              setCurrentPhotoIndex(newIndex);
            }
          }}
        >
          <div
            className="flex justify-center items-center"
            style={{ width: "100%", height: "100%" }}
          >
            <Image src={imageArrowIcon} alt="arrow icon" />
          </div>
        </div>
        <div
          className="absolute rounded-full"
          style={{
            backgroundColor: "rgba(0,0,0,0.7)",
            width: "100px",
            height: "100px",
            top: "40%",
            left: 10,
            zIndex: 102,
          }}
          onClick={() => {
            const newIndex = currentPhotoIndex - 1;

            if (newIndex >= 0) {
              setCurrentPhotoIndex(newIndex);
            }
          }}
        >
          <div
            className="flex justify-center items-center"
            style={{
              width: "100%",
              height: "100%",
              transform: "rotate(3.142rad)",
            }}
          >
            <Image src={imageArrowIcon} alt="arrow icon" />
          </div>
        </div>
        <div
          className="absolute"
          style={{
            left: "50%",
            bottom: 20,
            zIndex: 101,
          }}
        >
          <div className="flex flex-row gap-3">
            {[0, 0, 0].map((_, index) => {
              return (
                <div
                  key={index}
                  className="rounded-full"
                  style={{
                    width: "14px",
                    height: "14px",
                    backgroundColor:
                      index === currentPhotoIndex ? "#FFF" : "#000",
                    opacity: index === currentPhotoIndex ? "100%" : "50%",
                  }}
                ></div>
              );
            })}
          </div>
        </div>
      </div>

      <div id="card_content" className="pt-20 pl-8 pr-8">
        <h1 className="text-5xl ml-8">Restaurant title</h1>
        <div
          className="flex flex-row mt-6"
          style={{ fontSize: "36px", fontWeight: "600", lineHeight: "48px" }}
        >
          <div className="inline-block w-1/2">
            <div className="flex flex-row gap-5">
              <Image src={pointIcon} alt="Point icon" />
              <span>Lviv, st. Krakivska, 7</span>
            </div>
            <div className="flex flex-row gap-5">
              <Image src={clockIcon} alt="Working hours icon" />
              <span>10:00 — 22:00</span>{" "}
            </div>
            <div className="flex flex-row gap-5">
              <Image src={averagePriceIcon} alt="Price icon" />
              <span>150-360</span>
            </div>
          </div>
          <div className="inline-block w-1/2">
            <div className="flex flex-row gap-5">
              <Image src={restaurantIcon} alt="Food type icon" />
              <span>Italic food</span>
            </div>
            <div className="flex flex-row gap-5">
              <Image src={phoneIcon} alt="Phone icon" />
              <span>0963406073</span>
            </div>
            <div className="flex flex-row gap-5">
              <Image src={moreDetailsIcon} alt="Menu icon" />
              <span>Menu</span>
            </div>
          </div>
        </div>
        <div
          className="mt-6"
          style={{ fontSize: "25px", fontWeight: "600", lineHeight: "34px" }}
        >
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi eget
          faucibus tortor. Vivamus blandit eros in enim mollis, vel lobortis
          neque eleifend. Sed a consectetur tellus, ut sodales nibh. Lorem ipsum
          dolor sit amet, consectetur adipiscing elit. Nullam ut nulla urna.
          Aliquam dolor nisl, convallis sit amet diam ut, tempor euismod massa.
          Etiam commodo placerat libero, ut placerat elit sagittis vel. Aenean
          dignissim suscipit metus nec ornare. Phasellus sed risus quis metus
          vulputate mollis. Maecenas et justo at augue semper sagittis nec quis
          purus. Aenean auctor eros neque, vel mollis tortor lobortis vitae.
        </div>
      </div>
      <div className="pt-6 pl-8 pr-8">
        <h1 className="text-5xl ml-8 mb-4">Client's Review</h1>
        <hr className="pb-5" />
      </div>
    </div>
  );
}
